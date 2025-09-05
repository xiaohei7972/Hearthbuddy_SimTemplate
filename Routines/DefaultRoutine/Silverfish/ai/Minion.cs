using Triton.Game.Mapping;

namespace HREngine.Bots
{
    using System;
    using System.Collections.Generic;
    using Triton.Game;

    public class Minion
    {
        //dont silence----------------------------
        public int anzGotDmg = 0;//受到伤害次数
        public int GotDmgValue = 0;//受到伤害总和
        public int anzGotHealed = 0;//受到治疗次数
        public int GotHealedValue = 0;//受到治疗总和
        public bool gotInspire = false;//得到激励
        public bool isHero = false;//是否为英雄
        public bool own; //是否为己方
        public int pID = 0; //PID
        public CardDB.cardNameEN name = CardDB.cardNameEN.unknown;//随从名称
        public CardDB.cardNameCN nameCN = CardDB.cardNameCN.未知;//随从中文名称
        public TAG_CLASS cardClass = TAG_CLASS.INVALID;//随从类别
        public int synergy = 0;//职业契合度，即各种族（机械鱼人恶魔野兽）与职业相关性
        public Handmanager.Handcard handcard;
        //手牌信息，如果Minion中储存的内容不够的话，可以调用这个获取更多的信息，例如 m.handcard.card
        public int entitiyID = -1;//实例ID
        //public int id = -1;//delete this
        public int zonepos = 0;//随从放置位置
        public bool playedThisTurn = false;//在这回合使用
        public bool playedPrevTurn = false;//在上回合使用
        public int numAttacksThisTurn = 0;//这回合攻击了几次
        public int canAttcksNums = 1;//可攻击的次数
        public bool immuneWhileAttacking = false;//攻击时免疫
        public bool allreadyAttacked = false;//已经被攻击过
        public bool cantAttackHeroes = false;//无法攻击英雄
        public bool cantAttack = false;//无法攻击
        public CardDB.Card deathrattle2;//亡语2号，比如其他随从的亡语技能转移

        //暗影狂乱，直到回合结束，获得一个攻击力小于或等于3的敌方随从的控制权
        public bool shadowmadnessed = false;//暗影狂乱
        //我方回合开始被消灭
        public bool destroyOnOwnTurnStart = false; // 在己方回合开始时摧毁
        //敌方回合开始被消灭
        public bool destroyOnEnemyTurnStart = false; // 在敌方回合开始时摧毁
        //我方回合结束被消灭
        public bool destroyOnOwnTurnEnd = false; // 在己方回合结束时摧毁
        //敌方回合结束被消灭
        public bool destroyOnEnemyTurnEnd = false; // 在敌方回合结束时摧毁
        //回合开始时变更所有权，如暗影狂乱结束后的归还
        public bool changeOwnerOnTurnStart = false; //己方回合开始时更改所有者

        public bool conceal = false;//隐藏（直到你的下个回合，使所有友方随从获得潜行）
        public int ancestralspirit = 0; //先祖之魂，使一个随从获得“亡语：再次召唤该随从。
        public int desperatestand = 0;//殊死一搏，使一个随从获得“亡语：回到战场，并具有1点生命值。”
        public int souloftheforest = 0;//丛林之魂，使你的所有随从获得“亡语：召唤一个2/2的树人”。
        public int stegodon = 0;//剑龙骑术
        public int livingspores = 0;//活性孢子 亡语：召唤两个1/1的植物。
        public int explorershat = 0;//探险帽 使一个随从获得 + 1/+1，亡语：将一个探险帽置入你的手牌。
        public int libramofwisdom = 0;//智慧圣契

        public int returnToHand = 0;//回到手牌
        public int infest = 0;//寄生感染 使你的所有随从获得 “亡语：随机将一张野兽牌置入你的手牌”。

        public int ownBlessingOfWisdom = 0;//我方智慧祝福
        public int enemyBlessingOfWisdom = 0;//敌方智慧祝福
        public int ownPowerWordGlory = 0;//我方真言术：耀
        public int enemyPowerWordGlory = 0;//敌方真言术：耀
        public int spellpower = 0;//法术强度
        public bool cantBeTargetedBySpellsOrHeroPowers = false;//无法成为法术或英雄技能的目标
        public int Hp = 0;//当前血量
        public int maxHp = 0;//最大血量
        public int armor = 0;//护甲值（英雄）

        public int Angr = 0;//攻击力
        public int AdjacentAngr = 0;//相邻buff攻击力加成
        public int tempAttack = 0;//临时攻击力
        public int justBuffed = 0;//仅仅buff

        public bool Ready = false;//攻击准备就绪

        public bool taunt = false;//嘲讽
        public bool wounded = false;//受伤
        public bool divineshild = false;//圣盾
        public bool windfury = false; //风怒
        public bool frozen = false;//冻结
        public bool stealth = false;//潜行
        public bool immune = false;//免疫
        public bool untouchable = false;//不可触碰
        public bool exhausted = false;//用尽的   法力值?
        public bool lifesteal = false;//吸血
        public int dormant = 0;//休眠
        public bool outcast = false;//流放
        public bool reborn = false;//复生
        public bool poisonous = false;//剧毒

        //public bool modular = false; //磁力
        public int charge = 0;//冲锋
        public int rush = 0;//突袭
        private bool _elusive = false; //扰魔
        private bool _overkill = false;//超杀
        private bool _enraged = false;//激怒
        private bool _spellburst = false;//法术迸发
        private bool _frenzy = false;//暴怒
        private bool _honorableKill = false;// 荣耀击杀


        //激怒
        public bool Enraged
        {
            get { return _enraged; }
            set { _enraged = value; }
        }
        //法术迸发
        public bool Spellburst
        {
            get { return _spellburst; }
            set { _spellburst = value; }
        }
        //暴怒
        public bool Frenzy
        {
            get { return _frenzy; }
            set { _frenzy = value; }
        }
        /// <summary>
        /// 荣耀击杀
        /// </summary>
        public bool HonorableKill
        {
            get { return _honorableKill; }
            set { _honorableKill = value; }
        }
        /// <summary>
        /// 超杀
        /// </summary>
        public bool Overkill
        {
            get { return _overkill; }
            set { _overkill = value; }
        }
        //扰魔
        public bool Elusive
        {
            get { return _elusive; }
            set { _elusive = value; }
        }
        public int hChoice = 0;
        public bool cantLowerHPbelowONE = false;//血量无法低于1

        public string enchs = "";// 附魔效果

        public bool silenced = false;//沉默
        public bool playedFromHand = false;//从手牌中打出
        public bool extraParam = false;//扩展参数1
        public int extraParam2 = 0;//扩展参数2

        public string Status
        {
            get
            {
                return "{" + zonepos.ToString() + "} " + " (" + Angr + "/" + Hp + ") " + handcard.card.nameCN + "\n " +
                    (frozen ? "[冻结]" : "") + (!Ready || cantAttack ? "[无法攻击]" : "[可攻击]") + (windfury ? "[风怒]" : "") + (taunt ? "[嘲讽]" : "")
                    + (divineshild ? "[圣盾]" : "") + (stealth ? "[隐身]" : "") + (immune ? "[免疫]" : "") + (untouchable ? "[不可触碰]" : "") + (lifesteal ? "[吸血]" : "")
                     + (dormant != 0 ? "[休眠(" + dormant.ToString() + ")]" : "") + (reborn ? "[复生]" : "") + (poisonous ? "[剧毒]" : "")
                      + (Spellburst ? "[法术迸发]" : "") + (HonorableKill ? "[荣耀击杀]" : "") + (Overkill ? "[超杀]" : "") + (Elusive ? "[扰魔]" : "");
            }
        }

        public int CooldownTurn = 0;//地标冷却回合

        public Minion()
        {
            this.handcard = new Handmanager.Handcard();
        }

        public Minion(Minion m)
        {
            //dont silence----------------------------
            //this.anzGotDmg = m.anzGotDmg;
            //this.GotDmgValue = m.GotDmgValue;
            //this.anzGotHealed = m.anzGotHealed;


            this.gotInspire = m.gotInspire;
            this.isHero = m.isHero;
            this.own = m.own;

            this.name = m.name;
            this.nameCN = m.nameCN;
            this.cardClass = m.cardClass;
            this.synergy = m.synergy;
            this.handcard = m.handcard;
            this.deathrattle2 = m.deathrattle2;
            this.entitiyID = m.entitiyID;
            this.zonepos = m.zonepos;

            this.allreadyAttacked = m.allreadyAttacked;

            this.playedThisTurn = m.playedThisTurn;
            this.playedPrevTurn = m.playedPrevTurn;
            this.numAttacksThisTurn = m.numAttacksThisTurn;

            this.immuneWhileAttacking = m.immuneWhileAttacking;
            this.cantAttackHeroes = m.cantAttackHeroes;
            this.cantAttack = m.cantAttack;

            this.shadowmadnessed = m.shadowmadnessed;

            this.ancestralspirit = m.ancestralspirit;
            this.desperatestand = m.desperatestand;
            this.destroyOnOwnTurnStart = m.destroyOnOwnTurnStart; // depends on own!
            this.destroyOnEnemyTurnStart = m.destroyOnEnemyTurnStart; // depends on own!
            this.destroyOnOwnTurnEnd = m.destroyOnOwnTurnEnd; // depends on own!
            this.destroyOnEnemyTurnEnd = m.destroyOnEnemyTurnEnd; // depends on own!
            this.changeOwnerOnTurnStart = m.changeOwnerOnTurnStart;

            this.conceal = m.conceal;
            this.souloftheforest = m.souloftheforest;
            this.stegodon = m.stegodon;
            this.livingspores = m.livingspores;
            this.explorershat = m.explorershat;
            this.libramofwisdom = m.libramofwisdom;

            this.returnToHand = m.returnToHand;
            this.infest = m.infest;

            this.ownBlessingOfWisdom = m.ownBlessingOfWisdom;
            this.enemyBlessingOfWisdom = m.enemyBlessingOfWisdom;
            this.ownPowerWordGlory = m.ownPowerWordGlory;
            this.enemyPowerWordGlory = m.enemyPowerWordGlory;
            this.spellpower = m.spellpower;

            this.Hp = m.Hp;
            this.maxHp = m.maxHp;
            this.armor = m.armor;

            this.Angr = m.Angr;
            this.AdjacentAngr = m.AdjacentAngr;
            this.tempAttack = m.tempAttack;
            this.justBuffed = m.justBuffed;

            this.Ready = m.Ready;

            this.taunt = m.taunt;
            this.wounded = m.wounded;

            this.divineshild = m.divineshild;
            this.windfury = m.windfury;
            this.frozen = m.frozen;
            this.stealth = m.stealth;
            this.immune = m.immune;
            this.untouchable = m.untouchable;
            this.exhausted = m.exhausted;
            this.Elusive = m.Elusive;//扰魔
            this.Spellburst = m.Spellburst;//法术迸发
            this.Overkill = m.Overkill;//超杀
            this.Frenzy = m.Frenzy;//暴怒
            this.HonorableKill = m.HonorableKill;//荣耀击杀
            this.charge = m.charge;
            this.rush = m.rush;
            this.hChoice = m.hChoice;
            this.poisonous = m.poisonous;
            this.enchs = m.enchs;

            this.lifesteal = m.lifesteal;
            this.dormant = m.dormant;
            this.outcast = m.outcast;
            this.reborn = m.reborn;
            this.cantLowerHPbelowONE = m.cantLowerHPbelowONE;

            this.silenced = m.silenced;
            // this.cantBeTargetedBySpellsOrHeroPowers = m.cantBeTargetedBySpellsOrHeroPowers;


            this.CooldownTurn = m.CooldownTurn;
        }

        public void setMinionToMinion(Minion m)
        {

            //dont silence----------------------------
            this.anzGotDmg = m.anzGotDmg;
            this.GotDmgValue = m.GotDmgValue;
            this.anzGotHealed = m.anzGotHealed;
            this.gotInspire = m.gotInspire;
            this.isHero = m.isHero;
            this.own = m.own;

            this.name = m.name;
            this.nameCN = m.nameCN;
            this.cardClass = m.cardClass;
            this.synergy = m.synergy;
            this.handcard = m.handcard;
            this.deathrattle2 = m.deathrattle2;

            this.zonepos = m.zonepos;


            this.allreadyAttacked = m.allreadyAttacked;
            this.numAttacksThisTurn = m.numAttacksThisTurn;
            this.immuneWhileAttacking = m.immuneWhileAttacking;
            this.cantAttackHeroes = m.cantAttackHeroes;
            this.cantAttack = m.cantAttack;

            this.shadowmadnessed = m.shadowmadnessed;

            this.ancestralspirit = m.ancestralspirit;
            this.desperatestand = m.desperatestand;
            this.destroyOnOwnTurnStart = m.destroyOnOwnTurnStart; // depends on own!
            this.destroyOnEnemyTurnStart = m.destroyOnEnemyTurnStart; // depends on own!
            this.destroyOnOwnTurnEnd = m.destroyOnOwnTurnEnd; // depends on own!
            this.destroyOnEnemyTurnEnd = m.destroyOnEnemyTurnEnd; // depends on own!
            this.changeOwnerOnTurnStart = m.changeOwnerOnTurnStart;

            this.conceal = m.conceal;
            this.souloftheforest = m.souloftheforest;
            this.stegodon = m.stegodon;
            this.livingspores = m.livingspores;
            this.explorershat = m.explorershat;
            this.libramofwisdom = m.libramofwisdom;

            this.returnToHand = m.returnToHand;
            this.infest = m.infest;

            this.ownBlessingOfWisdom = m.ownBlessingOfWisdom;
            this.enemyBlessingOfWisdom = m.enemyBlessingOfWisdom;
            this.ownPowerWordGlory = m.ownPowerWordGlory;
            this.enemyPowerWordGlory = m.enemyPowerWordGlory;
            this.spellpower = m.spellpower;

            this.Hp = m.Hp;
            this.maxHp = m.maxHp;
            this.armor = m.armor;

            this.Angr = m.Angr;
            this.AdjacentAngr = m.AdjacentAngr;
            this.tempAttack = m.tempAttack;


            this.taunt = m.taunt;
            this.wounded = m.wounded;

            this.divineshild = m.divineshild;
            this.windfury = m.windfury;
            this.frozen = m.frozen;
            this.stealth = m.stealth;
            this.immune = m.immune;
            this.untouchable = m.untouchable;
            this.exhausted = m.exhausted;

            this.Elusive = m.Elusive;//扰魔
            this.Spellburst = m.Spellburst;//法术迸发
            this.Overkill = m.Overkill; //超杀
            this.Frenzy = m.Frenzy;//暴怒
            this.HonorableKill = m.HonorableKill;//荣耀击杀
            this.charge = m.charge;
            this.rush = m.rush;
            this.hChoice = m.hChoice;
            this.dormant = m.dormant;
            if ((m.charge > 0 || m.rush > 0) && !m.frozen && !m.silenced && m.dormant == 0) this.Ready = true;
            else this.Ready = false;
            if (m.rush > 0 && m.playedThisTurn) this.cantAttackHeroes = true;
            this.poisonous = m.poisonous;
            this.enchs = m.enchs;
            this.lifesteal = m.lifesteal;
            this.outcast = m.outcast;
            this.reborn = m.reborn;
            this.cantLowerHPbelowONE = m.cantLowerHPbelowONE;

            this.silenced = m.silenced;

            // this.cantBeTargetedBySpellsOrHeroPowers = m.cantBeTargetedBySpellsOrHeroPowers;


            this.CooldownTurn = m.CooldownTurn;
        }

        public int getRealAttack()
        {
            return this.Angr;
        }

        /// <summary>
        /// 受到伤害
        /// </summary>
        /// <param name="dmg"></param>
        /// <param name="p"></param>
        /// <param name="isMinionAttack"></param>
        /// <param name="dontCalcLostDmg"></param>
        public void getDamageOrHeal(int dmg, Playfield p, bool isMinionAttack, bool dontCalcLostDmg)
        {
            if (this.Hp <= 0) return;

            if (this.immune && dmg > 0 || this.untouchable) return;

            int damage = dmg;
            int heal = 0;
            if (dmg < 0) heal = -dmg;

            if (this.isHero)
            {
                if (dmg > 0)
                {
                    dmg += p.anzOldWoman;
                }
                // 己方英雄收到伤害或者治疗
                if (this.own)
                {
                    if (p.anzTamsin && dmg > 0 && !p.enemyHero.immune)
                    {
                        p.enemyHero.getDamageOrHeal(dmg, p, false, false);
                        p.evaluatePenality -= dmg * 4;
                        return;
                    }
                    if (p.ownHero.armor < dmg || dmg < 0)
                    {
                        p.healOrDamageTimes++;
                        // foreach (Handmanager.Handcard hc in p.owncards)
                        // {
                        //     if (hc.card.nameCN == CardDB.cardNameCN.血肉巨人 && hc.getManaCost(p) <= 3 && hc.getManaCost(p) > 0) p.evaluatePenality -= 10;
                        // }
                        // p.evaluatePenality -= 3;
                        if (dmg < 0)
                        {
                            p.healTimes++;
                        }
                    }
                    else if (p.ownHero.armor >= dmg)
                    {
                        p.evaluatePenality += 5;
                    }
                    if (p.ownWeapon.name == CardDB.cardNameEN.cursedblade) dmg += dmg;
                    if (p.enemyWeapon.name == CardDB.cardNameEN.theimmovableobject)
                    {
                        if (dmg % 2 == 0) dmg -= (int)(dmg / 2);
                        else dmg -= (int)(dmg / 2) + 1;
                    }
                    if (p.anzOwnAnimatedArmor > 0 && dmg > 0) dmg = 1;
                    if (p.anzOwnBolfRamshield > 0 && dmg > 0)
                    {
                        int rest = this.armor - dmg;
                        this.armor = Math.Max(0, rest);
                        if (rest < 0)
                        {
                            foreach (Minion m in p.ownMinions)
                            {
                                if (m.name == CardDB.cardNameEN.bolframshield)
                                {
                                    m.getDamageOrHeal(-rest, p, true, false);
                                    break;
                                }
                            }
                        }
                        return;
                    }
                    /*
                    黑眼
                    if (p.anzDark > 0 && dmg > 0 && !p.anzTamsin)
                    {
                        p.mana += p.anzDark;
                        if (p.mana > p.ownMaxMana)
                        {
                            p.mana = p.ownMaxMana;
                        }
                        else if(p.ownQuest.maxProgress != 1000)
                        {
                            p.evaluatePenality -= 10;
                            if (p.owncarddraw > 0) p.evaluatePenality -= 15;
                        }
                    }
                    任务进度
                    if (p.ownQuest != null  && p.ownQuest.maxProgress != 1000 && dmg > 0)
                    {
                        int spellDmg = p.getSpellDamageDamage(3);
                        // 是无证造成的伤害
                        if(dmg == 5 && (p.ownHero.Hp < 16 && p.enemyMinions.Count > 3 ) )
                        {
                            foreach(Minion m in p.ownMinions)
                            {
                                if(m.handcard.card.nameCN == CardDB.cardNameCN.无证药剂师)
                                {
                                    p.evaluatePenality += 70;
                                }
                            }
                        }
                        switch (p.ownQuest.Id)
                        {
                            case CardDB.cardIDEnum.SW_091:
                                p.ownQuest.questProgress += dmg;
                                if (p.ownQuest.questProgress >= p.ownQuest.maxProgress)
                                {
                                    p.evaluatePenality -= 50;
                                    p.evaluatePenality += (p.ownQuest.questProgress - p.ownQuest.maxProgress) * 20;
                                    p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_091t, questProgress = 0, maxProgress = 8 };
                                    p.minionGetDamageOrHeal(p.enemyHero, spellDmg);
                                    p.minionGetDamageOrHeal(p.ownHero, -spellDmg);
                                }
                                else
                                {
                                    p.evaluatePenality -= dmg * 2;
                                }
                                break;
                            case CardDB.cardIDEnum.SW_091t:
                                p.ownQuest.questProgress += dmg;
                                if (p.ownQuest.questProgress >= p.ownQuest.maxProgress)
                                {
                                    p.evaluatePenality -= 50;
                                    p.evaluatePenality += (p.ownQuest.questProgress - p.ownQuest.maxProgress) * 20;
                                    p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_091t3, questProgress = 0, maxProgress = 8 };
                                    p.minionGetDamageOrHeal(p.enemyHero, spellDmg);
                                    p.minionGetDamageOrHeal(p.ownHero, -spellDmg);
                                }
                                else
                                {
                                    p.evaluatePenality -= dmg * 2;
                                }
                                break;
                            case CardDB.cardIDEnum.SW_091t3:
                                if (p.anzTamsin) break;
                                p.ownQuest.questProgress += dmg;
                                if (p.ownQuest.questProgress >= p.ownQuest.maxProgress)
                                {
                                    p.evaluatePenality -= 10;
                                    p.evaluatePenality += (p.ownQuest.questProgress - p.ownQuest.maxProgress) * 5;
                                    p.ownQuest.Reset();
                                    p.drawACard(CardDB.cardIDEnum.SW_091t4, true, true);
                                }
                                else
                                {
                                    p.evaluatePenality -= dmg * 2;
                                }
                                break;
                        }
                    }else if(dmg > 0)
                    {
                        // 任务完成
                        if (Probabilitymaker.Instance.ownGraveyard.ContainsKey(CardDB.cardIDEnum.SW_091))
                        {
                            p.evaluatePenality += dmg * 8;
                        }
                    }
                    */



                }
                else
                {
                    if (p.anzEnemyAnimatedArmor > 0 && dmg > 0) dmg = 1;
                    if (p.enemyWeapon.name == CardDB.cardNameEN.cursedblade) dmg += dmg;
                    if (p.enemyWeapon.name == CardDB.cardNameEN.theimmovableobject)
                    {
                        if (dmg % 2 == 0) dmg -= (int)(dmg / 2);
                        else dmg -= (int)(dmg / 2) + 1;
                    }
                    if (p.anzEnemyBolfRamshield > 0 && dmg > 0)
                    {
                        int rest = this.armor - dmg;
                        this.armor = Math.Max(0, rest);
                        if (rest < 0)
                        {
                            foreach (Minion m in p.enemyMinions)
                            {
                                if (m.name == CardDB.cardNameEN.bolframshield)
                                {
                                    m.getDamageOrHeal(-rest, p, true, false);
                                    break;
                                }
                            }
                        }
                        return;
                    }
                }

                int copy = this.Hp;
                if (heal > 0)
                {
                    this.Hp = Math.Min(this.maxHp, this.Hp + heal);
                    if (copy < this.Hp)
                    {
                        p.tempTrigger.charsGotHealed++;
                        this.anzGotHealed++;
                        this.GotHealedValue += heal;
                    }
                }
                else if (dmg > 0)
                {
                    int rest = this.armor - dmg;
                    if (rest < 0) this.Hp += rest;
                    this.armor = Math.Max(0, this.armor - dmg);


                    if (this.cantLowerHPbelowONE && this.Hp <= 0) this.Hp = 1;
                    if (copy > this.Hp)
                    {
                        this.anzGotDmg++;
                        this.GotDmgValue += dmg;
                        if (this.own)
                        {
                            p.tempTrigger.ownMinionsGotDmg++;
                            p.tempTrigger.ownHeroGotDmg++;
                        }
                        else
                        {
                            p.tempTrigger.enemyMinionsGotDmg++;
                            p.tempTrigger.enemyHeroGotDmg++;
                        }
                        if (!this.own) // Todo: 不猜测对方奥秘 可能存在bug场景
                            p.secretTrigger_HeroGotDmg(this.own, dmg);
                    }
                }
                return;
            }

            //its a Minion--------------------------------------------------------------

            // AmitusThePeacekeeper效果：限制随从每次受到的伤害不超过2点
            if (p.ownAmitusThePeacekeeper && this.own)// 己方随从
            {
                if (damage > 2) // 只对伤害进行处理
                    damage = Math.Min(damage, 2);
            }
            else if (!this.own && p.enemyAmitusThePeacekeeper) // 敌方随从
            {
                if (damage > 2) // 只对伤害进行处理
                    damage = Math.Min(damage, 2);
            }

            if (damage >= 1)
            {
                switch (this.handcard.card.cardIDenum)
                {
                    case CardDB.cardIDEnum.YOP_035:// 月牙
                    case CardDB.cardIDEnum.VAC_527://龙族美餐
                        if (!this.silenced)
                            this.Hp -= 1;
                        break;
                    default:
                        this.Hp -= damage;
                        break;
                }
            }

            bool woundedbefore = this.wounded;
            if (damage > 0) this.allreadyAttacked = true;

            if (damage > 0 && this.divineshild)
            {
                p.minionLosesDivineShield(this);
                if (!own && !dontCalcLostDmg && p.turnCounter == 0)
                {
                    if (isMinionAttack)
                    {
                        p.lostDamage += damage - 1;
                    }
                    else
                    {
                        p.lostDamage += (damage - 1) * (damage - 1);
                    }
                }
                return;
            }

            if (this.cantLowerHPbelowONE && damage >= 1 && damage >= this.Hp) damage = this.Hp - 1;

            if (!own && !dontCalcLostDmg && this.Hp < damage && p.turnCounter == 0)
            {
                if (isMinionAttack)
                {
                    p.lostDamage += (damage - this.Hp);
                }
                else
                {
                    p.lostDamage += (damage - this.Hp) * (damage - this.Hp);
                }
            }

            int hpcopy = this.Hp;



            if (heal >= 1)
            {
                if (own && !dontCalcLostDmg && heal <= 999 && this.Hp + heal > this.maxHp) p.lostHeal += this.Hp + heal - this.maxHp;

                this.Hp = this.Hp + Math.Min(heal, this.maxHp - this.Hp);
            }



            if (this.Hp > hpcopy)
            {
                //minionWasHealed
                p.tempTrigger.minionsGotHealed++;
                p.tempTrigger.charsGotHealed++;
                this.anzGotHealed++;
                this.GotHealedValue += heal;
            }
            else if (this.Hp < hpcopy)
            {
                if (this.own) p.tempTrigger.ownMinionsGotDmg++;
                else p.tempTrigger.enemyMinionsGotDmg++;

                // if (p.anzAcidmaw > 0)
                // {
                //     if (p.anzAcidmaw == 1)
                //     {
                //         if (this.name != CardDB.cardNameEN.acidmaw) this.Hp = 0;
                //     }
                //     else this.Hp = 0;
                // }

                this.anzGotDmg++;
                this.GotDmgValue += dmg;
            }

            if (this.maxHp == this.Hp)
            {
                this.wounded = false;
            }
            else
            {
                this.wounded = true;
            }



            // if (this.name == CardDB.cardNameEN.lightspawn && !this.silenced)
            // {
            //     this.Angr = this.Hp;
            // }

            if (woundedbefore && !this.wounded)
            {
                this.handcard.card.sim_card.onEnrageStop(p, this);
            }

            if (!woundedbefore && this.wounded)
            {
                this.handcard.card.sim_card.onEnrageStart(p, this);
            }

            if (this.Hp <= 0)
            {
                this.minionDied(p);
            }

        }

        /// <summary>
        /// 随从死亡
        /// </summary>
        /// <param name="p"></param>
        public void minionDied(Playfield p)
        {
            if (this.own)
            {
                // 加入坟场
                if (!p.ownGraveyard.ContainsKey(this.handcard.card.cardIDenum))
                {
                    p.ownGraveyard.Add(this.handcard.card.cardIDenum, 1);
                }
                else
                {
                    p.ownGraveyard[this.handcard.card.cardIDenum]++;
                }
            }
            // 复生
            if (this.reborn)
            {
                CardDB.Card kid = handcard.card;
                List<Minion> tmp = own ? p.ownMinions : p.enemyMinions;
                int pos = zonepos - 1;
                p.callKid(kid, pos, own);
                tmp[pos].Hp = 1;
                tmp[pos].wounded = false;
                if (tmp[pos].Hp < tmp[pos].maxHp) tmp[pos].wounded = true;
                tmp[pos].reborn = false;
            }
            // if (this.name == CardDB.cardNameEN.stalagg)
            // {
            //     p.stalaggDead = true;
            // }
            // else
            // {
            //     if (this.name == CardDB.cardNameEN.feugen) p.feugenDead = true;
            // }



            if (own)
            {
                p.tempTrigger.ownMinionsDied++;
                p.ownMinionsDied++;
                if (this.taunt) p.anzOwnTaunt--;
                foreach (CardDB.Race race in this.handcard.card.GetRaces())
                {
                    switch (race)
                    {
                        case CardDB.Race.ALL:
                            p.tempTrigger.ownBeastDied++;
                            p.tempTrigger.ownMechanicDied++;
                            p.tempTrigger.ownMurlocDied++;
                            continue;
                        case CardDB.Race.PET: p.tempTrigger.ownBeastDied++; continue;
                        case CardDB.Race.MECHANICAL: p.tempTrigger.ownMechanicDied++; continue;
                        case CardDB.Race.MURLOC: p.tempTrigger.ownMurlocDied++; continue;
                    }
                }
                // if (this.handcard.card.race == CardDB.Race.PET)
                // {
                //     p.tempTrigger.ownBeastDied++;
                // }
                // else if (this.handcard.card.race == CardDB.Race.MECHANICAL)
                // {
                //     p.tempTrigger.ownMechanicDied++;
                // }
                // else if (this.handcard.card.race == CardDB.Race.MURLOC)
                // {
                //     p.tempTrigger.ownMurlocDied++;
                // }
            }
            else
            {
                p.tempTrigger.enemyMinionsDied++;
                if (this.taunt) p.anzEnemyTaunt--;
                foreach (CardDB.Race race in this.handcard.card.GetRaces())
                {
                    switch (race)
                    {
                        case CardDB.Race.ALL:
                            p.tempTrigger.enemyBeastDied++;
                            p.tempTrigger.enemyMechanicDied++;
                            p.tempTrigger.enemyMurlocDied++;
                            continue;
                        case CardDB.Race.PET: p.tempTrigger.ownBeastDied++; continue;
                        case CardDB.Race.MECHANICAL: p.tempTrigger.enemyMechanicDied++; continue;
                        case CardDB.Race.MURLOC: p.tempTrigger.enemyMurlocDied++; continue;
                    }
                }

                // if (this.handcard.card.race == CardDB.Race.PET)
                // {
                //     p.tempTrigger.enemyBeastDied++;
                // }
                // else if (this.handcard.card.race == CardDB.Race.MECHANICAL)
                // {
                //     p.tempTrigger.enemyMechanicDied++;
                // }
                // else if (this.handcard.card.race == CardDB.Race.MURLOC)
                // {
                //     p.tempTrigger.enemyMurlocDied++;
                // }
            }

            if (p.diedMinions != null)
            {
                GraveYardItem gyi = new GraveYardItem(this.handcard.card.cardIDenum, this.entitiyID, this.own, GraveYardItem.EnumGraveyardStatus.Died);
                p.diedMinions.Add(gyi);
            }
        }

        /// <summary>
        /// 更新就绪状态
        /// </summary>
        public void updateReadyness()
        {
            Ready = false;
            if (cantAttack) return;
            if (this.handcard.card.dormant > 0 && !this.silenced && this.playedThisTurn) return;

            if (isHero)
            {
                //旧
                // if (!frozen && Angr != 0 && ((charge >= 1 && playedThisTurn) || !playedThisTurn) && (numAttacksThisTurn == 0 || (numAttacksThisTurn == 1 && windfury))) Ready = true;
                //新
                if (!frozen && Angr != 0 && (numAttacksThisTurn == 0 || (numAttacksThisTurn == 1 && windfury))) Ready = true;
                return;
                // if (!frozen)
                // {
                //     if (Angr > 0)
                //     {
                //         if (canAttcksNums > numAttacksThisTurn)
                //         {
                //             Ready = true;
                //         }
                //     }
                // }
            }


            if (!frozen)
            {
                if ((charge >= 1 && playedThisTurn) || !playedThisTurn || shadowmadnessed)
                {
                    if (numAttacksThisTurn == 0 || (numAttacksThisTurn == 1 && windfury))
                    {
                        Ready = true;
                    }
                }
                else
                {
                    if (charge == 0 && rush > 0 && playedThisTurn)
                    {
                        if ((numAttacksThisTurn == 0 || (numAttacksThisTurn == 1 && windfury)))
                        {
                            cantAttackHeroes = true;
                            Ready = true;
                        }
                    }
                }
            }


            // if (!frozen && (((charge >= 1 && playedThisTurn)) || !playedThisTurn || shadowmadnessed) && (numAttacksThisTurn == 0 || (numAttacksThisTurn == 1 && windfury) || (!silenced && this.name == CardDB.cardNameEN.v07tr0n && numAttacksThisTurn <= 3))) Ready = true;
            // if (!frozen && (((charge == 0 && rush >= 1 && playedThisTurn)) || !playedThisTurn || shadowmadnessed) && (numAttacksThisTurn == 0 || (numAttacksThisTurn == 1 && windfury) || (!silenced && this.name == CardDB.cardNameEN.v07tr0n && numAttacksThisTurn <= 3))) { Ready = true; cantAttackHeroes = true; }
            if (this.handcard.card.type == CardDB.cardtype.LOCATION)
            {
                if (this.CooldownTurn == 0)
                    Ready = true;
                else if (this.CooldownTurn > 0)
                    Ready = false;
            }

        }
        //被沉默
        public void becomeSilence(Playfield p)
        {
            if (this.untouchable) return;
            // 直接变形不香吗？
            int Atk = this.Angr;
            int Hp = this.Hp;
            if (this.Angr != this.handcard.card.Attack) Atk = this.handcard.card.Attack;
            if (this.Hp > this.maxHp) Hp = this.handcard.card.Health;
            p.minionTransform(this, CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_tk1));
            this.Angr = Atk;
            this.Hp = this.maxHp = Hp;
            return;

            if (own)
            {
                p.spellpower -= spellpower;
                if (this.taunt) p.anzOwnTaunt--;
            }
            else
            {
                p.enemyspellpower -= spellpower;
                if (this.taunt) p.anzEnemyTaunt--;
            }
            spellpower = 0;

            deathrattle2 = null;
            p.minionGetOrEraseAllAreaBuffs(this, false);
            //buffs
            ancestralspirit = 0;
            desperatestand = 0;
            destroyOnOwnTurnStart = false;
            destroyOnEnemyTurnStart = false;
            destroyOnOwnTurnEnd = false;
            destroyOnEnemyTurnEnd = false;
            changeOwnerOnTurnStart = false;
            conceal = false;
            souloftheforest = 0;
            stegodon = 0;
            livingspores = 0;
            explorershat = 0;
            libramofwisdom = 0;

            returnToHand = 0;
            infest = 0;
            deathrattle2 = null;
            if (this.name == CardDB.cardNameEN.moatlurker && p.LurkersDB.ContainsKey(this.entitiyID)) p.LurkersDB.Remove(this.entitiyID);

            ownBlessingOfWisdom = 0;
            enemyBlessingOfWisdom = 0;
            ownPowerWordGlory = 0;
            enemyPowerWordGlory = 0;

            // cantBeTargetedBySpellsOrHeroPowers = false;
            cantAttackHeroes = false;
            cantAttack = false;

            charge = 0;
            rush = 0;
            hChoice = 0;
            taunt = false;
            divineshild = false;
            windfury = false;
            frozen = false;
            stealth = false;
            immune = false;
            poisonous = false;
            enchs = "";
            cantLowerHPbelowONE = false;
            lifesteal = false;
            dormant = 0;
            outcast = false;
            reborn = false;
            //超杀
            Overkill = false;
            //荣耀击杀
            HonorableKill = false;

            //delete enrage (if minion is silenced the first time)
            if (wounded && handcard.card.Enrage && !silenced)
            {
                handcard.card.sim_card.onEnrageStop(p, this);
            }

            //reset attack
            Angr = handcard.card.Attack;
            tempAttack = 0;//we dont toutch the adjacent buffs!


            //reset hp and heal it
            if (maxHp < handcard.card.Health)//minion has lower maxHp as his card -> heal his hp
            {
                Hp += handcard.card.Health - maxHp; //heal minion
            }
            maxHp = handcard.card.Health;
            if (Hp > maxHp) Hp = maxHp;

            if (!silenced)//minion WAS not silenced, deactivate his aura
            {
                handcard.card.sim_card.onAuraEnds(p, this);
            }

            silenced = true;
            this.updateReadyness();
            p.minionGetOrEraseAllAreaBuffs(this, true);
            if (own)
            {
                p.tempTrigger.ownMinionsChanged = true;
            }
            else
            {
                p.tempTrigger.enemyMininsChanged = true;
            }
            if (this.shadowmadnessed)
            {
                this.shadowmadnessed = false;
                p.shadowmadnessed--;
                p.minionGetControlled(this, !own, false);
            }

            if (this.handcard.card.nameCN == CardDB.cardNameCN.暮光幼龙)
            {
                this.Hp = 1;
            }
        }
        //攻击之后的状态
        public Minion GetTargetForMinionWithSurvival(Playfield p, bool own)
        {
            if (this.Angr == 0) return null;
            if ((own ? p.enemyMinions.Count : p.ownMinions.Count) < 1) return (own ? p.enemyHero : p.ownHero);
            Minion target = new Minion();
            Minion targetTaumt = new Minion();
            foreach (Minion m in own ? p.enemyMinions : p.ownMinions)
            {
                if (m.taunt && !m.silenced)
                {
                    if (this.Hp > m.Hp && (m.Hp + m.Angr + m.Angr * (m.windfury ? 1 : 0)) > (targetTaumt.Hp + targetTaumt.Angr + targetTaumt.Angr * (targetTaumt.windfury ? 1 : 0))) targetTaumt = m;
                }
                else
                {
                    if (this.Hp > m.Hp && (m.Hp + m.Angr + m.Angr * (m.windfury ? 1 : 0)) > (target.Hp + target.Angr + target.Angr * (target.windfury ? 1 : 0))) target = m;
                }
            }
            if (targetTaumt.Hp > 0) return targetTaumt;
            if (target.Hp > 0) return target;
            return null;
        }

        /// <summary>
        /// 特殊随从的特效添加位置
        /// </summary>
        /// <param name="enchants"></param>
        /// <param name="ownPlayerControler"></param>
        public void loadEnchantments(List<miniEnch> enchants, int ownPlayerControler)
        {
            foreach (miniEnch me in enchants)
            {
                // reborns and destoyings----------------------------------------------
                this.enchs += " " + me.CARDID;

                if (me.CARDID == CardDB.cardIDEnum.EX1_363e || me.CARDID == CardDB.cardIDEnum.EX1_363e2) //BlessingOfWisdom
                {//智慧祝福
                    if (me.controllerOfCreator == ownPlayerControler)
                    {
                        this.ownBlessingOfWisdom++;
                    }
                    else
                    {
                        this.enemyBlessingOfWisdom++;
                    }
                }

                if (me.CARDID == CardDB.cardIDEnum.AT_013e) //PowerWordGlory
                {//真言术：耀
                    if (me.controllerOfCreator == ownPlayerControler)
                    {
                        this.ownPowerWordGlory++;
                    }
                    else
                    {
                        this.enemyPowerWordGlory++;
                    }
                }


                if (me.CARDID == CardDB.cardIDEnum.EX1_316e) //overwhelmingpower
                {//力量的代价
                    if (me.controllerOfCreator == ownPlayerControler)
                    {
                        this.destroyOnOwnTurnEnd = true;
                    }
                    else
                    {
                        this.destroyOnEnemyTurnEnd = true;
                    }
                }

                if (me.CARDID == CardDB.cardIDEnum.EX1_334e) //Dark Command
                {//暗影狂乱
                    this.shadowmadnessed = true;
                }

                if (me.CARDID == CardDB.cardIDEnum.FP1_030e) //Necrotic Aura
                {//死灵光环
                    //todo Eure Zauber kosten in diesem Zug (5) mehr.
                }
                if (me.CARDID == CardDB.cardIDEnum.NEW1_029t) //death to millhouse!
                {
                    // todo spells cost (0) this turn!
                }
                if (me.CARDID == CardDB.cardIDEnum.EX1_612o) //Power of the Kirin Tor
                {
                    // todo Your next Secret costs (0).
                }
                // if (me.CARDID == CardDB.cardIDEnum.EX1_084e) //warsongcommander
                // {
                //      this.charge++;
                //  }
                switch (me.CARDID)
                {
                    //ToDo: TBUD_1	Each turn, if you have less health then a your opponent, summon a free minion

                    //末尾带e 带符号的都不是正常牌
                    // destroy-------------------------------------------------
                    case CardDB.cardIDEnum.CS2_063e:
                        if (me.controllerOfCreator == ownPlayerControler) this.destroyOnOwnTurnStart = true;
                        else this.destroyOnEnemyTurnStart = true;   //corruption
                        continue;
                    case CardDB.cardIDEnum.DREAM_05e:
                        if (me.controllerOfCreator == ownPlayerControler) this.destroyOnOwnTurnStart = true;
                        else this.destroyOnEnemyTurnStart = true;   //nightmare
                        continue;

                    // deathrattles-------------------------------------------------
                    case CardDB.cardIDEnum.LOE_105e: this.explorershat++; continue;
                    case CardDB.cardIDEnum.UNG_956e: this.returnToHand++; continue;

                    case CardDB.cardIDEnum.CS2_038e: this.ancestralspirit++; continue;
                    case CardDB.cardIDEnum.ICC_244e: this.desperatestand++; continue;
                    case CardDB.cardIDEnum.EX1_158e: this.souloftheforest++; continue;
                    case CardDB.cardIDEnum.UNG_952e: this.stegodon++; continue;
                    case CardDB.cardIDEnum.UNG_999t2e: this.livingspores++; continue;

                    case CardDB.cardIDEnum.OG_045a: this.infest++; continue;
                    //conceal-------------------------------------------------
                    case CardDB.cardIDEnum.EX1_128e: this.conceal = true; continue;
                    case CardDB.cardIDEnum.NEW1_014e: this.conceal = true; continue;
                    case CardDB.cardIDEnum.PART_004e: this.conceal = true; continue;
                    case CardDB.cardIDEnum.OG_080de: this.conceal = true; continue;

                    //cantLowerHPbelowONE-------------------------------------------------
                    case CardDB.cardIDEnum.NEW1_036e: this.cantLowerHPbelowONE = true; continue; //commandingshout
                    case CardDB.cardIDEnum.NEW1_036e2: this.cantLowerHPbelowONE = true; continue; //commandingshout

                    //spellpower-------------------------------------------------
                    case CardDB.cardIDEnum.GVG_010b: this.spellpower++; continue; //velenschosen
                    case CardDB.cardIDEnum.AT_006e: this.spellpower++; continue; //dalaran
                    case CardDB.cardIDEnum.EX1_584e: this.spellpower++; continue; //ancient mage

                    //charge-------------------------------------------------
                    case CardDB.cardIDEnum.AT_071e: this.charge++; continue;
                    case CardDB.cardIDEnum.CS2_103e2: this.charge++; continue;
                    case CardDB.cardIDEnum.TB_AllMinionsTauntCharge: this.charge++; continue;
                    case CardDB.cardIDEnum.DS1_178e: this.charge++; continue;

                    //adjacentbuffs-------------------------------------------------
                    case CardDB.cardIDEnum.EX1_565o: this.AdjacentAngr += 2; continue; //flametongue
                    case CardDB.cardIDEnum.EX1_162o: this.AdjacentAngr += 1; continue; //dire wolf alpha

                    //tempbuffs-------------------------------------------------
                    case CardDB.cardIDEnum.CS2_083e: this.tempAttack += 1; continue;
                    case CardDB.cardIDEnum.EX1_549o: this.tempAttack += 2; this.immuneWhileAttacking = true; continue;
                    case CardDB.cardIDEnum.AT_057o: this.immuneWhileAttacking = true; continue;
                    case CardDB.cardIDEnum.WORK_017e: this.immune = true; continue;
                    case CardDB.cardIDEnum.AT_039e: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.AT_132_DRUIDe: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.CS2_005o: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.CS2_011o: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.EX1_046e: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.GVG_057a: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.CS2_046e: this.tempAttack += 3; continue;
                    case CardDB.cardIDEnum.CS2_105e: this.tempAttack += 4; continue;
                    case CardDB.cardIDEnum.EX1_570e: this.tempAttack += 4; continue;
                    case CardDB.cardIDEnum.OG_047e: this.tempAttack += 4; continue;
                    case CardDB.cardIDEnum.NAX12_04e: this.tempAttack += 6; continue;
                    case CardDB.cardIDEnum.GVG_011a: this.tempAttack += -2; continue;
                    case CardDB.cardIDEnum.CFM_661e: this.tempAttack += -3; continue;
                    case CardDB.cardIDEnum.BRM_001e: this.tempAttack += -1000; continue;
                    case CardDB.cardIDEnum.TU4c_008e: this.tempAttack += 8; continue;
                    case CardDB.cardIDEnum.CS2_045e: this.tempAttack += 3; continue;
                    case CardDB.cardIDEnum.CS2_188o: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.CS2_017o: this.tempAttack += 1; continue;
                    // FIXME 休眠回合数
                    case CardDB.cardIDEnum.BT_737e: this.dormant = me.entity.GetTag(GAME_TAG.SCORE_VALUE_1) - me.entity.GetTag(GAME_TAG.SCORE_VALUE_2); continue;
                    case CardDB.cardIDEnum.UNG_067t1e: if (ownPlayerControler == Hrtprozis.Instance.getOwnController()) Hrtprozis.Instance.updateCrystalCore(5); continue;
                    case CardDB.cardIDEnum.UNG_116te: if (ownPlayerControler == Hrtprozis.Instance.getOwnController()) Hrtprozis.Instance.updateOwnMinionsInDeckCost0(true); continue;
                    case CardDB.cardIDEnum.LOE_019e://todo: 要改deathrattle2结构,可能存在多次复制(铜须)
                        {
                            this.extraParam2 = me.copyDeathrattle;
                            var idEnum = CardDB.cardIDEnum.None;
                            var ent = me.entity;
                        Loop:
                            var deathEntity = TritonHs.GameState.GetEntity(ent.GetTag(GAME_TAG.TAG_SCRIPT_DATA_NUM_1));
                            var cardId = deathEntity.GetCardId();
                            if (string.IsNullOrEmpty(cardId))
                                cardId = deathEntity.GetEntityDef().GetCardId();
                            idEnum = CardDB.Instance.cardIdstringToEnum(cardId);
                            if (idEnum == CardDB.cardIDEnum.None ||
                                idEnum == CardDB.cardIDEnum.LOE_019)//复制了另一个迅猛龙
                            {
                                var atts = ent.GetAttachments();
                                if (atts.Count > 0)
                                {
                                    ent = atts[0];//todo: 要改deathrattle2结构,可能存在多次复制(铜须)
                                    goto Loop;
                                }
                            }
                            else
                            {
                                this.deathrattle2 = CardDB.Instance.getCardDataFromID(idEnum);
                            }
                        }
                        continue;
                    case CardDB.cardIDEnum.SW_091t5: if (ownPlayerControler == Hrtprozis.Instance.getOwnController()) Hrtprozis.Instance.anzTamsin = true; continue;
                    case CardDB.cardIDEnum.DMF_240e: if (ownPlayerControler == Hrtprozis.Instance.getOwnController()) Hrtprozis.Instance.updatePlayerAttachments(true); continue;
                    // 过期货物
                    case CardDB.cardIDEnum.ULD_163e:
                        this.extraParam2 = me.copyDeathrattle;
                        var idEnum_163 = CardDB.cardIDEnum.None;
                        var ent_163 = me.entity;
                        var deathEntity_163 = TritonHs.GameState.GetEntity(ent_163.GetTag(GAME_TAG.TAG_SCRIPT_DATA_NUM_1));
                        var cardId_163 = deathEntity_163.GetCardId();
                        if (string.IsNullOrEmpty(cardId_163))
                            cardId_163 = deathEntity_163.GetEntityDef().GetCardId();
                        idEnum_163 = CardDB.Instance.cardIdstringToEnum(cardId_163);
                        this.deathrattle2 = CardDB.Instance.getCardDataFromID(idEnum_163);
                        continue;
                }
            }
        }

        /// <summary>
        /// 打印中文信息用，中文名 + 身材，方便辨识
        /// </summary>
        /// <returns></returns>
        public string info()
        {
            if (isHero)
            {
                if (own)
                    return "己方英雄" + "(" + Hp + ")";
                else
                    return "敌方英雄" + "(" + Hp + ")";
            }
            else if (handcard.card.type == CardDB.cardtype.MOB)
            {
                return nameCN.ToString() + "(" + Angr + "," + Hp + ")";
            }
            else
            {
                return nameCN.ToString();
            }
        }

    }
    public class miniEnch
    {
        public Entity entity;
        public CardDB.cardIDEnum CARDID = CardDB.cardIDEnum.None;
        public int creator = 0; // the minion
        public int controllerOfCreator = 0; // own or enemys buff?
        public int copyDeathrattle = 0;

        public miniEnch(CardDB.cardIDEnum id, int crtr, int controler, int copydr, Entity entity)
        {
            this.CARDID = id;
            this.creator = crtr;
            this.controllerOfCreator = controler;
            this.copyDeathrattle = copydr;
            this.entity = entity;
        }

    }
}