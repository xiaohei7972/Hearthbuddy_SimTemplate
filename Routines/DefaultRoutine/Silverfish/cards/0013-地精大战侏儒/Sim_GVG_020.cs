using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_020 : SimTemplate //* 邪能火炮 Fel Cannon
//At the end of your turn, deal 2 damage to a non-Mech minion.
//在你的回合结束时，对一个非机械随从造成2点伤害。 
    {

        

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                
                int ownNonMechs = 0;
                Minion ownTemp = null;
                foreach (Minion m in p.ownMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race != TAG_RACE.MECHANICAL)
                    {
                        if (ownTemp == null) ownTemp = m;
                        ownNonMechs++;
                    }
                }

                int enemyNonMechs = 0;
                Minion enemyTemp = null;
                foreach (Minion m in p.enemyMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race != TAG_RACE.MECHANICAL)
                    {
                        if (enemyTemp == null) enemyTemp = m;
                        enemyNonMechs++;
                    }
                }

                
                if (ownNonMechs >= 1 && enemyNonMechs >= 1)
                {
                    if (ownNonMechs >= enemyNonMechs)
                    {
                        p.minionGetDamageOrHeal(ownTemp, 2, true);
                        return;
                    }
                    p.minionGetDamageOrHeal(enemyTemp, 2, true);
                    return;
                }

                if (ownNonMechs >= 1)
                {
                    p.minionGetDamageOrHeal(ownTemp, 2, true);
                    return;
                }

                if (enemyNonMechs >= 1)
                {
                    p.minionGetDamageOrHeal(enemyTemp, 2, true);
                    return;
                }
            }
        }
    }
}