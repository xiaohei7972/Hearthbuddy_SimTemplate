using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_222 : SimTemplate //* 暴风城勇士 Stormwind Champion
	{
		//Your other minions have +1/+1.
		//你的其他随从获得+1/+1。
		
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnStormwindChamps++;
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 1);
                }
            }
            else
            {
                p.anzEnemyStormwindChamps++;
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 1);
                }
            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnStormwindChamps--;
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -1, -1);
                }
            }
            else
            {
                p.anzEnemyStormwindChamps--;
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -1, -1);
                }
            }
        }

	}
}