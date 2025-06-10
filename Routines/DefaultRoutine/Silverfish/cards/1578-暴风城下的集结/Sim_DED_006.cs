using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_006 : SimTemplate //* 重拳先生 Mr. Smite
    {
        //你的海盗获得冲锋。
        //Your Pirates have Charge.
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnMrSmite++;
                foreach (Minion m in p.ownMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PIRATE) p.minionGetCharge(m);
                }
            }
            else
            {
                p.anzEnemyMrSmite++;
                foreach (Minion m in p.enemyMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PIRATE) p.minionGetCharge(m);
                }
            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnMrSmite--;
                foreach (Minion m in p.ownMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PIRATE) p.minionLostCharge(m);
                }
            }
            else
            {
                p.anzEnemyMrSmite--;
                foreach (Minion m in p.enemyMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PIRATE) p.minionLostCharge(m);
                }
            }
        }
    }
}
