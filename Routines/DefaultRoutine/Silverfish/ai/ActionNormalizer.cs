using System.Collections.Generic;
using System.Linq;

namespace HREngine.Bots
{
    public class ActionNormalizer
    {
        PenalityManager penman = PenalityManager.Instance;
        Helpfunctions help = Helpfunctions.Instance;
        Settings settings = Settings.Instance;

        public struct targetNdamage
        {
            public int targetEntity;
            public int receivedDamage;

            public targetNdamage(int ent, int dmg)
            {
                this.targetEntity = ent;
                this.receivedDamage = dmg;
            }
        }

        /// <summary>
        /// 调整动作的顺序，以提高效率和潜在的伤害输出。特别是在致命伤害检查中，此方法尝试重新排列动作顺序以获得最大伤害。
        /// </summary>
        /// <param name="p">当前的游戏状态。</param>
        /// <param name="isLethalCheck">是否正在进行致命伤害检查。</param>
        public void adjustActions(Playfield p, bool isLethalCheck)
        {
            // 如果敌方有秘密或动作数小于2，不调整动作顺序
            if (p.enemySecretCount > 0 || p.playactions.Count < 2) return;

            // 定义重排序后的动作列表和随机伤害的动作ID及其对应的伤害
            List<Action> reorderedActions = new List<Action>();
            Dictionary<int, Dictionary<int, int>> rndActIdsDmg = new Dictionary<int, Dictionary<int, int>>();
            Playfield tmpPlOld = new Playfield();

            // 致命伤害检查
            if (isLethalCheck)
            {
                if (Ai.Instance.botBase.getPlayfieldValue(p) < 10000) return; // 如果当前场地值低于10000，则不调整
                Playfield tmpPf = new Playfield();
                if (tmpPf.anzEnemyTaunt > 0) return; // 如果敌方有嘲讽随从，则不调整

                Dictionary<Action, int> actDmgDict = new Dictionary<Action, int>();
                tmpPf.enemyHero.Hp = 30; // 初始化敌方英雄血量为30
                try
                {
                    int useability = 0;
                    foreach (Action a in p.playactions)
                    {
                        if (a.actionType == actionEnum.useHeroPower) useability = 1;
                        if (a.actionType == actionEnum.attackWithHero) useability++;
                        int actDmd = tmpPf.enemyHero.Hp + tmpPf.enemyHero.armor;
                        tmpPf.doAction(a);
                        actDmd -= (tmpPf.enemyHero.Hp + tmpPf.enemyHero.armor);
                        actDmgDict.Add(a, actDmd);
                    }
                    if (useability > 1) return;
                }
                catch
                {
                    return;
                }

                // 根据动作造成的伤害从高到低进行排序
                foreach (var pair in actDmgDict.OrderByDescending(pair => pair.Value))
                {
                    reorderedActions.Add(pair.Key);
                }

                tmpPf = new Playfield();
                foreach (Action a in reorderedActions)
                {
                    if (!isActionPossible(tmpPf, a)) return;
                    try
                    {
                        tmpPf.doAction(a);
                    }
                    catch
                    {
                        this.printError(p.playactions, reorderedActions, a);
                        return;
                    }
                }

                // 如果调整后的场地值低于10000，则不进行调整
                if (Ai.Instance.botBase.getPlayfieldValue(tmpPf) < 10000) return;
            }
            else
            {
                // 非致命伤害检查
                bool damageRandom = false;
                bool rndBeforeDamageAll = false;
                Action aa;
                for (int i = 0; i < p.playactions.Count; i++)
                {
                    aa = p.playactions[i];
                    switch (aa.actionType)
                    {
                        case actionEnum.playcard:
                            if (damageRandom && penman.DamageAllEnemysDatabase.ContainsKey(aa.card.card.nameEN)) rndBeforeDamageAll = true;
                            else if (penman.DamageRandomDatabase.ContainsKey(aa.card.card.nameEN)) damageRandom = true;
                            break;
                    }
                }

                int aoeEnNum = 0;
                int outOfPlace = 0;
                bool totemiccall = false;
                List<Action> rndAct = new List<Action>();
                List<Action> rndActTmp = new List<Action>();
                for (int i = 0; i < p.playactions.Count; i++)
                {
                    damageRandom = false;
                    aa = p.playactions[i];
                    reorderedActions.Add(aa);
                    switch (aa.actionType)
                    {
                        case actionEnum.useHeroPower:
                            if (aa.card.card.nameEN == CardDB.cardNameEN.totemiccall) totemiccall = true;
                            break;
                        case actionEnum.playcard:
                            if (penman.DamageAllEnemysDatabase.ContainsKey(aa.card.card.nameEN))
                            {
                                if (i != aoeEnNum)
                                {
                                    if (totemiccall && aa.card.card.type == CardDB.cardtype.SPELL) return;
                                    reorderedActions.RemoveAt(i);
                                    reorderedActions.Insert(aoeEnNum, aa);
                                    outOfPlace++;
                                }
                                aoeEnNum++;
                            }
                            else if (rndBeforeDamageAll && aa.card.card.type == CardDB.cardtype.SPELL && penman.DamageRandomDatabase.ContainsKey(aa.card.card.nameEN))
                            {
                                damageRandom = true;
                                Playfield tmp = new Playfield(tmpPlOld);
                                tmpPlOld.doAction(aa);

                                Dictionary<int, int> actIdDmg = new Dictionary<int, int>();
                                if (tmp.enemyHero.Hp != tmpPlOld.enemyHero.Hp) actIdDmg.Add(tmpPlOld.enemyHero.entitiyID, tmp.enemyHero.Hp - tmpPlOld.enemyHero.Hp);
                                if (tmp.ownHero.Hp != tmpPlOld.ownHero.Hp) actIdDmg.Add(tmpPlOld.ownHero.entitiyID, tmp.ownHero.Hp - tmpPlOld.ownHero.Hp);
                                bool found = false;
                                foreach (Minion m in tmp.enemyMinions)
                                {
                                    found = false;
                                    foreach (Minion nm in tmpPlOld.enemyMinions)
                                    {
                                        if (m.entitiyID == nm.entitiyID)
                                        {
                                            found = true;
                                            if (m.Hp != nm.Hp) actIdDmg.Add(m.entitiyID, m.Hp - nm.Hp);
                                            break;
                                        }
                                    }
                                    if (!found) actIdDmg.Add(m.entitiyID, m.Hp);
                                }
                                foreach (Minion m in tmp.ownMinions)
                                {
                                    found = false;
                                    foreach (Minion nm in tmpPlOld.ownMinions)
                                    {
                                        if (m.entitiyID == nm.entitiyID)
                                        {
                                            found = true;
                                            if (m.Hp != nm.Hp) actIdDmg.Add(m.entitiyID, m.Hp - nm.Hp);
                                            break;
                                        }
                                    }
                                    if (!found) actIdDmg.Add(m.entitiyID, m.Hp);
                                }
                                rndActIdsDmg.Add(aa.card.entity, actIdDmg);
                            }
                            break;
                    }
                    if (!damageRandom) tmpPlOld.doAction(aa);
                }

                if (outOfPlace == 0) return;

                Playfield tmpPf = new Playfield();
                foreach (Action a in reorderedActions)
                {
                    if (!isActionPossible(tmpPf, a)) return;
                    try
                    {
                        if (!(a.actionType == actionEnum.playcard && rndActIdsDmg.ContainsKey(a.card.entity)))
                            tmpPf.doAction(a);
                        else
                        {
                            tmpPf.playactions.Add(a);
                            Dictionary<int, int> actIdDmg = rndActIdsDmg[a.card.entity];
                            if (actIdDmg.ContainsKey(tmpPf.enemyHero.entitiyID))
                                tmpPf.minionGetDamageOrHeal(tmpPf.enemyHero, actIdDmg[tmpPf.enemyHero.entitiyID]);
                            if (actIdDmg.ContainsKey(tmpPf.ownHero.entitiyID))
                                tmpPf.minionGetDamageOrHeal(tmpPf.ownHero, actIdDmg[tmpPf.ownHero.entitiyID]);
                            foreach (Minion m in tmpPf.enemyMinions)
                            {
                                if (actIdDmg.ContainsKey(m.entitiyID))
                                    tmpPf.minionGetDamageOrHeal(m, actIdDmg[m.entitiyID]);
                            }
                            foreach (Minion m in tmpPf.ownMinions)
                            {
                                if (actIdDmg.ContainsKey(m.entitiyID))
                                    tmpPf.minionGetDamageOrHeal(m, actIdDmg[m.entitiyID]);
                            }
                            tmpPf.doDmgTriggers();
                        }
                    }
                    catch
                    {
                        printError(p.playactions, reorderedActions, a);
                        return;
                    }
                }

                tmpPf.lostDamage = tmpPlOld.lostDamage;
                float newval = Ai.Instance.botBase.getPlayfieldValue(tmpPf);
                float oldval = Ai.Instance.botBase.getPlayfieldValue(tmpPlOld);

                if (oldval > newval) return;
            }
            help.logg("Old order of actions:");
            foreach (Action a in p.playactions) a.print();

            p.playactions.Clear();
            p.playactions.AddRange(reorderedActions);

            help.logg("New order of actions:");
        }

        /// <summary>
        /// 检查某个操作在当前的游戏状态下是否可行，包括使用地标的判断。
        /// </summary>
        /// <param name="p">当前的游戏状态。</param>
        /// <param name="a">要检查的操作。</param>
        /// <returns>如果操作可行，则返回 true；否则返回 false。</returns>
        private bool isActionPossible(Playfield p, Action a)
        {
            bool actionFound = false;

            // 根据操作类型进行不同的检查
            switch (a.actionType)
            {
                case actionEnum.playcard:
                    // 检查是否可以打出卡牌
                    foreach (Handmanager.Handcard hc in p.owncards)
                    {
                        if (hc.entity == a.card.entity)
                        {
                            // 判断法力值是否足够
                            if (p.mana >= hc.card.getManaCost(p, hc.manacost))
                            {
                                // 如果随从已满且尝试打出随从，则返回 false
                                if (p.ownMinions.Count >= 7)
                                    if (hc.card.type == CardDB.cardtype.MOB || hc.card.type == CardDB.cardtype.LOCATION)
                                        return actionFound;

                                actionFound = true;
                            }
                            break;
                        }
                    }
                    break;

                case actionEnum.attackWithMinion:
                    // 检查随从是否可以攻击
                    foreach (Minion m in p.ownMinions)
                    {
                        if (m.entitiyID == a.own.entitiyID)
                        {
                            // 如果随从没有准备好，则返回 false
                            if (!m.Ready)
                                return false;

                            actionFound = true;
                            break;
                        }
                    }
                    break;

                case actionEnum.attackWithHero:
                    // 检查英雄是否可以攻击
                    if (p.ownHero.Ready)
                        actionFound = true;
                    break;

                case actionEnum.useHeroPower:
                    // 检查英雄技能是否可以使用
                    if (p.ownAbilityReady && p.mana >= p.ownHeroAblility.card.getManaCost(p, p.ownHeroAblility.manacost))
                        actionFound = true;
                    break;

                case actionEnum.trade:
                    // 检查卡牌是否可以交易
                    foreach (Handmanager.Handcard hc in p.owncards)
                    {
                        if (hc.entity == a.card.entity)
                        {
                            // 检查是否满足交易的条件
                            if (hc.card.Tradeable && p.mana >= hc.card.TradeCost && p.ownDeckSize > 0)
                            {
                                actionFound = true;
                            }
                            break;
                        }
                    }
                    break;

                case actionEnum.useLocation:
                    // 检查地标是否可以使用
                    foreach (Minion m in p.ownMinions)
                    {
                        if (m.entitiyID == a.own.entitiyID)
                        {
                            // 确认地标类型并检查其冷却时间是否已经结束
                            if (m.handcard.card.type == CardDB.cardtype.LOCATION && m.CooldownTurn == 0)
                            {
                                actionFound = true;
                            }
                            break;
                        }
                    }
                    break;

                case actionEnum.useTitanAbility:
                    // 检查泰坦是否可以使用
                    foreach (Minion m in p.ownMinions)
                    {
                        if (m.entitiyID == a.own.entitiyID)
                        {
                            // 确认泰坦技能可否能使用
                            if (m.handcard.card.Titan && (!m.handcard.card.TitanAbilityUsed1 || !m.handcard.card.TitanAbilityUsed2 || !m.handcard.card.TitanAbilityUsed3))
                            {
                                actionFound = true;
                            }
                            break;
                        }
                    }
                    break;

                case actionEnum.forge:
                    // 检查卡牌是否可以锻造
                    foreach (Handmanager.Handcard hc in p.owncards)
                    {
                        if (hc.entity == a.card.entity)
                        {
                            // 检查是否满足交易的条件
                            if (hc.card.Forge && p.mana >= hc.card.ForgeCost && !hc.card.Forged)
                            {
                                actionFound = true;
                            }
                            break;
                        }
                    }
                    break;
            }

            // 如果在上面的检查中没有找到合适的操作，返回 false
            if (!actionFound)
                return false;

            // 如果操作有目标，则需要检查目标是否存在
            if (a.target != null)
            {
                actionFound = false;

                // 检查目标是否是敌方英雄或己方英雄
                if (p.enemyHero.entitiyID == a.target.entitiyID || p.ownHero.entitiyID == a.target.entitiyID)
                {
                    actionFound = true;
                }
                else
                {
                    // 检查目标是否是敌方或己方的随从
                    foreach (Minion m in p.enemyMinions)
                    {
                        if (m.entitiyID == a.target.entitiyID)
                        {
                            actionFound = true;
                            break;
                        }
                    }
                    if (!actionFound)
                    {
                        foreach (Minion m in p.ownMinions)
                        {
                            if (m.entitiyID == a.target.entitiyID)
                            {
                                actionFound = true;
                                break;
                            }
                        }
                    }
                }
            }

            return actionFound;
        }

        private void printError(List<Action> mainActList, List<Action> newActList, Action aError)
        {
            help.ErrorLog("Reordering actions error!");
            help.logg("Reordering actions error!\r\nError in action:");
            aError.print();
            help.logg("Main order of actions:");
            foreach (Action a in mainActList) a.print();
            help.logg("New order of actions:");
            foreach (Action a in newActList) a.print();
            return;
        }

        public void checkLostActions(Playfield p)
        {
            Playfield tmpPf = new Playfield();
            foreach (Action a in p.playactions)
            {
                if (a.target != null && a.own != null) a.own.own = !a.target.own;
                tmpPf.doAction(a);
            }
            MiniSimulator mainTurnSimulator = new MiniSimulator(6, 3000, 0);
            mainTurnSimulator.setSecondTurnSimu(settings.simulateEnemysTurn, settings.secondTurnAmount);
            mainTurnSimulator.setPlayAround(settings.playaround, settings.playaroundprob, settings.playaroundprob2);

            tmpPf.checkLostAct = true;
            tmpPf.isLethalCheck = p.isLethalCheck;

            float bestval = mainTurnSimulator.doallmoves(tmpPf);
            if (bestval > p.value)
            {
                p.playactions.Clear();
                p.playactions.AddRange(mainTurnSimulator.bestboard.playactions);
                p.value = bestval;
            }
        }
    }


}