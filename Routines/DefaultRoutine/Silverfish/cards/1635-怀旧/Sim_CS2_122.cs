using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_122 : SimTemplate //* 团队领袖 Raid Leader
	{
		//Your other minions have +1 Attack.
		//你的其他随从获得+1攻击力。
        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own)
            {
                p.anzOwnRaidleader++;
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 0);
                }
            }
            else
            {
                p.anzEnemyRaidleader++;
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 0);
                }
            }
            
		}

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnRaidleader--;
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -1, 0);
                }
            }
            else
            {
                p.anzEnemyRaidleader--;
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -1, 0);
                }
            }
        }

	}
}