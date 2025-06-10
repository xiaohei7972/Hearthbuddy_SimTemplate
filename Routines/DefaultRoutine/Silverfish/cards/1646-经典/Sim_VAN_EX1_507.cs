using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_VAN_EX1_507 : SimTemplate //* Murloc Warleader
	{
        // Your other Murlocs have +2 Attack.

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own) p.anzOwnMurlocWarleader++;
            else p.anzEnemyMurlocWarleader++;

            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ( m.Ready && (m.handcard.card.race == CardDB.Race.MURLOC || m.handcard.card.race == CardDB.Race.ALL) && own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 2, 0);
            }
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.anzOwnMurlocWarleader--;
            else p.anzEnemyMurlocWarleader--;

            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion mn in temp)
            {
                if (m.Ready && (m.handcard.card.race == CardDB.Race.MURLOC || m.handcard.card.race == CardDB.Race.ALL) && mn.entitiyID != m.entitiyID) p.minionGetBuffed(mn, -2, 0);
            }
        }
    }
}