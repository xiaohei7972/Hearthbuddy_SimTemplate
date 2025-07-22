using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_078 : SimTemplate //* 精英对决 Enter the Coliseum
//Destroy all minions except each player's highest Attack minion.
//除了每个玩家攻击力最高的随从之外，消灭所有其他随从。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = new List<Minion>(p.enemyMinions);
			if (temp.Count >= 2)
			{
				temp.Sort((a, b) => b.Angr.CompareTo(a.Angr));
				bool first = true;
				foreach (Minion m in temp)
				{
					if (first) { first = false; continue; }
					p.minionGetDestroyed(m);
				}
			}
			
			temp = new List<Minion>(p.ownMinions);
			if (temp.Count >= 2)
			{
				temp.Sort((a, b) => b.Angr.CompareTo(a.Angr));
				bool first = true;
				foreach (Minion m in temp)
				{
					if (first) { first = false; continue; }
					p.minionGetDestroyed(m);
				}
			}
		}
	}
}