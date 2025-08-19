namespace HREngine.Bots
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Movegenerator
    {
        PenalityManager pen = PenalityManager.Instance;

        private static Movegenerator instance;

        public static Movegenerator Instance
        {
            get
            {
                return instance ?? (instance = new Movegenerator());
            }
        }

        private Movegenerator()
        {
        }

        /// <summary>
        /// 生成潜在的动作列表，并对每个动作进行打分。
        /// </summary>
        /// <param name="p">当前的游戏状态。</param>
        /// <param name="usePenalityManager">是否使用惩罚值管理器。</param>
        /// <param name="useCutingTargets">是否使用目标剪枝。</param>
        /// <param name="own">是否为己方回合。</param>
        /// <returns>返回动作列表。</returns>
        public List<Action> getMoveList(Playfield p, bool usePenalityManager, bool useCutingTargets, bool own)
        {
            var ret = new List<Action>();
            if (p.complete || p.ownHero.Hp <= 0) return ret;

            var trgts = new List<Minion>();

            if (own)
            {
                var playedcards = new HashSet<string>();
                var cardNcost = new StringBuilder();

                foreach (var hc in p.owncards)
                {
                    if (hc.card.nameEN == CardDB.cardNameEN.unknown) continue;

                    int cardCost = hc.card.getManaCost(p, hc.manacost);

                    // 检查卡牌的打出条件
                    if ((p.nextSpellThisTurnCostHealth && hc.card.type == CardDB.cardtype.SPELL) ||
                        (p.nextMurlocThisTurnCostHealth && hc.card.race == CardDB.Race.MURLOC))
                    {
                        if (p.ownHero.Hp <= cardCost && !p.ownHero.immune) continue;
                    }
                    else if (p.mana < cardCost) continue;

                    // 检查是否在此回合内打出了相同的卡牌
                    cardNcost.Clear();
                    cardNcost.Append(hc.card.cardIDenum).Append(hc.manacost);
                    if (playedcards.Contains(cardNcost.ToString()) && !hc.card.Outcast && hc.enchs.Count == 0) continue;
                    playedcards.Add(cardNcost.ToString());

                    bool isChoice = hc.card.choice;
                    CardDB.Card c = hc.card;

                    for (int choice = isChoice ? 1 : 0; choice <= (isChoice ? 2 : 1); choice++)
                    {
                        if (isChoice)
                        {
                            c = pen.getChooseCard(hc.card, choice);
                            if (p.ownFandralStaghelm > 0)
                            {
                                // 找到包含伤害或治疗效果的选择项
                                for (int i = 1; i <= 2; i++)
                                {
                                    var cTmp = pen.getChooseCard(hc.card, i);
                                    if (pen.DamageTargetDatabase.ContainsKey(cTmp.nameEN) ||
                                        (p.anzOwnAuchenaiSoulpriest > 0 && pen.HealTargetDatabase.ContainsKey(cTmp.nameEN)))
                                    {
                                        choice = i;
                                        c = cTmp;
                                        break;
                                    }
                                }
                            }
                        }

                        if (p.ownMinions.Count >= 7)
                            if (hc.card.type == CardDB.cardtype.MOB || hc.card.type == CardDB.cardtype.LOCATION)
                                continue;

                        trgts = c.getTargetsForCard(p, p.isLethalCheck, true);
                        if (trgts.Count == 0) continue;

                        // //非地标目标指向，移除地标
                        // if (c.type == CardDB.cardtype.MOB &&
                        //     c.cardIDenum != CardDB.cardIDEnum.VAC_529 &&
                        //     c.cardIDenum != CardDB.cardIDEnum.REV_023 && c.cardIDenum != CardDB.cardIDEnum.CORE_REV_023)
                        // {
                        //     trgts.RemoveAll(minion => minion != null &&
                        //           minion.handcard != null &&
                        //           minion.handcard.card != null &&
                        //           minion.handcard.card.type == CardDB.cardtype.LOCATION);

                        // }

                        // //如果是法术，移除扰魔、地标
                        // if (c.type == CardDB.cardtype.SPELL)
                        // {
                        //     trgts.RemoveAll(minion => minion != null &&
                        //           minion.handcard != null &&
                        //           minion.handcard.card != null &&
                        //           minion.handcard.card.Elusive);
                        //     trgts.RemoveAll(minion => minion != null &&
                        //           minion.handcard != null &&
                        //           minion.handcard.card != null &&
                        //           minion.handcard.card.type == CardDB.cardtype.LOCATION);
                        // }

                        int bestplace = p.getBestPlace(c, p.isLethalCheck);

                        foreach (var trgt in trgts)
                        {
                            int cardplayPenality = usePenalityManager ? pen.getPlayCardPenality(c, trgt, p, hc) : 0;
                            if (cardplayPenality <= 499)
                            {
                                ret.Add(new Action(actionEnum.playcard, hc, null, bestplace, trgt, cardplayPenality, choice));
                            }
                        }
                    }
                }

                // 处理可交易的卡牌
                foreach (var hc in p.owncards)
                {
                    if (hc.card.nameEN == CardDB.cardNameEN.unknown) continue;
                    if (hc.card.Tradeable && p.mana >= hc.card.TradeCost && p.ownDeckSize > 0)
                    {
                        ret.Add(new Action(actionEnum.trade, hc, null, 0, null, 0, 0));
                    }
                }

                // 处理可锻造的卡牌
                foreach (var hc in p.owncards)
                {
                    if (hc.card.nameEN == CardDB.cardNameEN.unknown) continue;
                    if (hc.card.Forge && p.mana >= hc.card.ForgeCost && !hc.card.Forged)
                    {
                        ret.Add(new Action(actionEnum.forge, hc, null, 0, null, 0, 0));
                    }
                }
            }

            // 获取英雄武器和随从的攻击目标
            trgts = p.GetAttackTargets(own, p.isLethalCheck);
            if (!p.isLethalCheck) trgts = this.cutAttackList(trgts);

            // 处理随从攻击
            var attackingMinions = new List<Minion>();
            foreach (var m in p.ownMinions)
            {
                if (m.numAttacksThisTurn == 1 && !m.frozen && !m.cantAttack)
                {
                    m.Ready = m.windfury && !m.silenced ||
                              p.ownMinions.Exists(prev => prev.handcard.card.nameCN == CardDB.cardNameCN.战场军官 && !prev.silenced);
                }

                if (m.Ready && m.Angr >= 1 && !m.frozen)
                {
                    attackingMinions.Add(m);
                }
            }

            attackingMinions = this.cutAttackList(attackingMinions);

            // 计算随从攻击的惩罚值
            foreach (var m in attackingMinions)
            {
                foreach (var trot in trgts)
                {
                    if (trot == null) continue;
                    if (trot.untouchable == true || (m.cantAttackHeroes && trot.isHero)) continue;

                    int attackPenality = usePenalityManager ? pen.getAttackWithMininonPenality(m, p, trot) : 0;
                    if (attackPenality <= 499)
                    {
                        ret.Add(new Action(actionEnum.attackWithMinion, null, m, 0, trot, attackPenality, 0));
                    }
                }
            }

            // 处理英雄攻击（武器）
            if ((own && p.ownHero.Ready && p.ownHero.Angr >= 1) || (!own && p.enemyHero.Ready && p.enemyHero.Angr >= 1))
            {
                foreach (var trot in trgts)
                {
                    if ((own ? p.ownWeapon.cantAttackHeroes : p.enemyWeapon.cantAttackHeroes) && trot.isHero) continue;

                    var heroAttackPen = usePenalityManager ? pen.getAttackWithHeroPenality(trot, p) : 0;
                    if (heroAttackPen <= 499)
                    {
                        ret.Add(new Action(actionEnum.attackWithHero, null, own ? p.ownHero : p.enemyHero, 0, trot, heroAttackPen, 0));
                    }
                }
            }

            // 使用己方英雄技能
            if (own && p.ownAbilityReady && p.mana >= p.ownHeroAblility.card.getManaCost(p, p.ownHeroAblility.manacost))
            {
                var c = p.ownHeroAblility.card;
                var choiceCount = c.choice ? 2 : 1;  // 如果是抉择卡牌，choiceCount为2，否则为1
                trgts = p.ownHeroAblility.card.getTargetsForHeroPower(p, true);
                for (var choice = 1; choice <= choiceCount; choice++)
                {
                    var chosenCard = c;

                    // 如果是抉择卡牌，根据choice获取不同的卡牌
                    if (c.choice)
                    {
                        chosenCard = pen.getChooseCard(p.ownHeroAblility.card, choice);
                    }

                    var playCardPenalty = 0;
                    var place = p.ownMinions.Count + 1;

                    foreach (var trot in trgts)
                    {
                        if (p.ownHeroAblility.card.nameCN == CardDB.cardNameCN.未知 && p.ownHeroName == HeroEnum.thief)
                        {
                            p.ownHeroAblility.card.nameCN = CardDB.cardNameCN.匕首精通;
                        }

                        if (usePenalityManager)
                        {
                            playCardPenalty = pen.getPlayCardPenality(chosenCard, trot, p, new Handmanager.Handcard());
                        }

                        if (playCardPenalty > 499) continue;
                        var a = new Action(actionEnum.useHeroPower, p.ownHeroAblility, null, place, trot, playCardPenalty, choice);
                        ret.Add(a);
                    }
                }
            }

            // 使用地标逻辑
            var usingMinions = (own ? p.ownMinions : p.enemyMinions)
                .Where(m => m.handcard.card.type == CardDB.cardtype.LOCATION && m.CooldownTurn == 0 && m.Ready)
                .ToList();
            foreach (var minion in usingMinions)
            {
                trgts = minion.handcard.card.getTargetsForLocation(p, p.isLethalCheck, true);
                if (trgts.Count > 0)
                {
                    foreach (var trot in trgts)
                    {
                        int useLocationPenalty = usePenalityManager ? pen.getUseLocationPenality(minion, trot, p) : 0;
                        if (useLocationPenalty <= 499)
                        {
                            ret.Add(new Action(actionEnum.useLocation, null, minion, 0, trot, useLocationPenalty, 0));
                        }
                    }
                }
                else if (minion.handcard.card.sim_card.GetUseAbilityReqs().Length == 0)
                {
                    ret.Add(new Action(actionEnum.useLocation, null, minion, 0, null, 0, 0));
                }
            }

            // 使用泰坦技能逻辑
            var titans = (own ? p.ownMinions : p.enemyMinions).Where(m => m.handcard.card.Titan).ToList();
            foreach (var titan in titans)
            {
                //初始化技能列表
                titan.handcard.card.TitanAbility = titan.handcard.card.GetTitanAbility();
                // 遍历每个技能
                for (int i = 0; i < 3; i++)
                {
                    if ((i == 0 && titan.handcard.card.TitanAbilityUsed1) ||
                        (i == 1 && titan.handcard.card.TitanAbilityUsed2) ||
                        (i == 2 && titan.handcard.card.TitanAbilityUsed3))
                    {
                        continue; // 如果技能已经使用过，跳过
                    }

                    CardDB.Card ability = titan.handcard.card.TitanAbility[i];
                    trgts = ability.getTargetsForCard(p, p.isLethalCheck, true);

                    //移除地标
                    trgts.RemoveAll(minion => minion != null &&
                                                            minion.handcard != null &&
                                                            minion.handcard.card != null &&
                                                            minion.handcard.card.type == CardDB.cardtype.LOCATION);


                    // 如果技能不需要目标，直接添加动作
                    if (trgts.Count == 0)
                    {
                        ret.Add(new Action(actionEnum.useTitanAbility, null, titan, 0, null, -100, 0, i + 1));
                        continue;
                    }

                    // 如果技能需要一个目标，生成对应的动作
                    foreach (var trot in trgts)
                    {
                        int titanAbilityPenalty = usePenalityManager ? pen.getUseTitanAbilityPenality(titan, trot, p) : 0;
                        if (titanAbilityPenalty <= 499)
                        {
                            ret.Add(new Action(actionEnum.useTitanAbility, null, titan, 0, trot, titanAbilityPenalty, 0, i + 1));
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// 剪枝，排除相同的目标
        /// </summary>
        /// <param name="oldlist"></param>
        /// <returns></returns>
        public List<Minion> cutAttackList(List<Minion> oldlist)
        {
            List<Minion> retvalues = new List<Minion>(oldlist.Count);
            List<Minion> addedmins = new List<Minion>(oldlist.Count);

            foreach (Minion m in oldlist)
            {
                if (m.isHero)
                {
                    retvalues.Add(m);
                    continue;
                }

                bool goingtoadd = true;
                bool isSpecial = m.handcard.card.isSpecialMinion;
                foreach (Minion mnn in addedmins)
                {
                    bool otherisSpecial = mnn.handcard.card.isSpecialMinion;
                    bool onlySpecial = isSpecial && otherisSpecial && !m.silenced && !mnn.silenced;
                    bool onlyNotSpecial = (!isSpecial || (isSpecial && m.silenced)) && (!otherisSpecial || (otherisSpecial && mnn.silenced));

                    if (onlySpecial && (m.name != mnn.name)) continue; // different name -> take it
                    if ((onlySpecial || onlyNotSpecial) && (mnn.Angr == m.Angr && mnn.Hp == m.Hp && mnn.divineshild == m.divineshild && mnn.taunt == m.taunt && mnn.poisonous == m.poisonous && mnn.lifesteal == m.lifesteal && m.handcard.card.isToken == mnn.handcard.card.isToken && mnn.handcard.card.race == m.handcard.card.race && mnn.Spellburst == m.Spellburst && mnn.cantAttackHeroes == m.cantAttackHeroes))
                    {
                        goingtoadd = false;
                        break;
                    }
                }

                if (goingtoadd)
                {
                    addedmins.Add(m);
                    retvalues.Add(m);
                }
                else
                {
                    continue;
                }
            }
            return retvalues;
        }

        public bool didAttackOrderMatters(Playfield p)
        {
            //return true;
            if (p.isOwnTurn)
            {
                if (p.enemySecretCount >= 1) return true;
                if (p.enemyHero.immune) return true;

            }
            else
            {
                if (p.ownHero.immune) return true;
            }
            List<Minion> enemym = (p.isOwnTurn) ? p.enemyMinions : p.ownMinions;
            List<Minion> ownm = (p.isOwnTurn) ? p.ownMinions : p.enemyMinions;

            int strongestAttack = 0;
            foreach (Minion m in enemym)
            {
                if (m.Angr > strongestAttack) strongestAttack = m.Angr;
                if (m.taunt) return true;
                if (m.name == CardDB.cardNameEN.dancingswords || m.name == CardDB.cardNameEN.deathlord) return true;
            }

            int haspets = 0;
            bool hashyena = false;
            bool hasJuggler = false;
            bool spawnminions = false;
            foreach (Minion m in ownm)
            {
                if (m.name == CardDB.cardNameEN.cultmaster) return true;
                if (m.name == CardDB.cardNameEN.knifejuggler) hasJuggler = true;
                if (m.Ready && m.Angr >= 1)
                {
                    if (m.AdjacentAngr >= 1) return true;//wolphalfa or flametongue is in play
                    if (m.name == CardDB.cardNameEN.northshirecleric) return true;
                    if (m.name == CardDB.cardNameEN.armorsmith) return true;
                    if (m.name == CardDB.cardNameEN.loothoarder) return true;
                    //if (m.name == CardDB.cardName.madscientist) return true; // dont change the tactic
                    if (m.name == CardDB.cardNameEN.sylvanaswindrunner) return true;
                    if (m.name == CardDB.cardNameEN.darkcultist) return true;
                    if (m.ownBlessingOfWisdom >= 1) return true;
                    if (m.ownPowerWordGlory >= 1) return true;
                    if (m.name == CardDB.cardNameEN.acolyteofpain) return true;
                    if (m.name == CardDB.cardNameEN.frothingberserker) return true;
                    if (m.name == CardDB.cardNameEN.flesheatingghoul) return true;
                    if (m.name == CardDB.cardNameEN.bloodmagethalnos) return true;
                    if (m.name == CardDB.cardNameEN.webspinner) return true;
                    if (m.name == CardDB.cardNameEN.tirionfordring) return true;
                    if (m.name == CardDB.cardNameEN.baronrivendare) return true;


                    //if (m.name == CardDB.cardName.manawraith) return true;
                    //buffing minions (attack with them last)
                    if (m.name == CardDB.cardNameEN.raidleader || m.name == CardDB.cardNameEN.stormwindchampion || m.name == CardDB.cardNameEN.timberwolf || m.name == CardDB.cardNameEN.southseacaptain || m.name == CardDB.cardNameEN.murlocwarleader || m.name == CardDB.cardNameEN.grimscaleoracle || m.name == CardDB.cardNameEN.leokk || m.name == CardDB.cardNameEN.fallenhero || m.name == CardDB.cardNameEN.warhorsetrainer) return true;


                    if (m.name == CardDB.cardNameEN.scavenginghyena) hashyena = true;
                    if (m.handcard.card.race == CardDB.Race.PET) haspets++;
                    if (m.name == CardDB.cardNameEN.harvestgolem || m.name == CardDB.cardNameEN.hauntedcreeper || m.souloftheforest >= 1 || m.stegodon >= 1 || m.livingspores >= 1 || m.infest >= 1 || m.ancestralspirit >= 1 || m.desperatestand >= 1 || m.explorershat >= 1 || m.returnToHand >= 1 || m.name == CardDB.cardNameEN.nerubianegg || m.name == CardDB.cardNameEN.savannahhighmane || m.name == CardDB.cardNameEN.sludgebelcher || m.name == CardDB.cardNameEN.cairnebloodhoof || m.name == CardDB.cardNameEN.feugen || m.name == CardDB.cardNameEN.stalagg || m.name == CardDB.cardNameEN.thebeast) spawnminions = true;

                }
            }

            if (haspets >= 1 && hashyena) return true;
            if (hasJuggler && spawnminions) return true;




            return false;
        }
    }

}