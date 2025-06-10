using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_173 : SimTemplate //* 维西纳 
	{
		public override void onAuraStarts(Playfield p, Minion own)
		{
			if (own.own)
            {
                if (p.ueberladung > 0)
                {
                    p.anzOwnRaidleader++;
                    foreach (Minion m in p.ownMinions)
                    {
                        if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 2, 0);
                    }
                }
            }
			else
            {
                if (p.ueberladung > 0)
                {
                    p.anzEnemyRaidleader++;
                    foreach (Minion m in p.enemyMinions)
                    {
                       if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, 2, 0);
                    }
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
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -2, 0);
                }
            }
            else
            {
                p.anzEnemyRaidleader--;
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entitiyID != m.entitiyID) p.minionGetBuffed(m, -2, 0);
                }
            }
        }
	}
}