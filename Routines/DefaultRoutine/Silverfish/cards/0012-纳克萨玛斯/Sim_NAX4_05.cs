using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX4_05 : SimTemplate //* 瘟疫 Plague
//Destroy all non-Skeleton minions.
//消灭所有不是骷髅的随从。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			foreach (Minion m in p.ownMinions)
            {
                if (m.name != CardDB.cardNameEN.skeleton) p.minionGetDestroyed(m);
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.name != CardDB.cardNameEN.skeleton) p.minionGetDestroyed(m);
            }
		}
	}
}