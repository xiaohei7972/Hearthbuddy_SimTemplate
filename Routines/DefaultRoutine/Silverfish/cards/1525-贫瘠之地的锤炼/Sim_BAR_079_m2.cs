using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_079_m2 : SimTemplate //* 大型魔像 Greater Golem
	{
        //{0}{1}
        //{0}{1}
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            Handmanager.Handcard hc = own.handcard;
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t14))
            {
                own.spellpower++;
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t14b))
            {
                own.spellpower+=2;
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t14c))
            {
                own.spellpower += 4;
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t15))
            {
                p.drawACard(CardDB.cardIDEnum.None, true);
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t15b))
            {
                p.drawACard(CardDB.cardIDEnum.None, true);
                p.drawACard(CardDB.cardIDEnum.None, true);
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t15c))
            {
                p.drawACard(CardDB.cardIDEnum.None, true);
                p.drawACard(CardDB.cardIDEnum.None, true);
                p.drawACard(CardDB.cardIDEnum.None, true);
                p.drawACard(CardDB.cardIDEnum.None, true);
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t4))
            {
                p.minionGetRush(own);
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t5))
            {
                own.taunt = true;
                p.anzOwnTaunt++;
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t6))
            {
                own.divineshild = true;
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t7))
            {
                own.lifesteal = true;
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t8))
            {
                own.stealth = true;
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t9))
            {
                own.poisonous = true;
            }

            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t10)) { p.allMinionOfASideGetBuffed(true, 1, 1); }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t10b)) { p.allMinionOfASideGetBuffed(true, 2, 2); }
            if (hc.enchs.Contains(CardDB.cardIDEnum.bar_079t10c)) { p.allMinionOfASideGetBuffed(true, 4, 4); }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t11)) {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_079_m2), own.zonepos, true);
                if (p.ownMinions.Count < 7)
                {
                    p.callKid(own.handcard.card, own.zonepos, own.own);
                    p.ownMinions[own.zonepos].setMinionToMinion(own);
                }
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t12)) {
                int cnt = 1;
                foreach(Minion m in p.enemyMinions)
                {
                    if(!m.frozen)
                    {
                        p.minionGetFrozen(m);
                        cnt--;
                    }
                    if (cnt <= 0) break;
                }
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t12b))
            {
                int cnt = 2;
                foreach (Minion m in p.enemyMinions)
                {
                    if (!m.frozen)
                    {
                        p.minionGetFrozen(m);
                        cnt--;
                    }
                    if (cnt <= 0) break;
                }
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t12c))
            {
                p.allMinionOfASideGetDamage(false, 0, true);
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t13))
            {
                if(p.enemyMinions.Count > 0)
                {
                    p.minionGetDamageOrHeal(p.getEnemyCharTargetForRandomSingleDamage(3, true), 3);
                }
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t13b))
            {
                if (p.enemyMinions.Count > 0)
                {
                    p.minionGetDamageOrHeal(p.getEnemyCharTargetForRandomSingleDamage(3, true), 3);
                }
                if (p.enemyMinions.Count > 0)
                {
                    p.minionGetDamageOrHeal(p.getEnemyCharTargetForRandomSingleDamage(3, true), 3);
                }
            }
            if (hc.enchs.Contains(CardDB.cardIDEnum.BAR_079t13c))
            {
                p.allMinionOfASideGetDamage(false, 3);
            }


        }
    }
}
