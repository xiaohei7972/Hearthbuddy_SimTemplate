using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_522 : SimTemplate //* 碾压墙 Crushing Walls
									 //Destroy your opponent's left and right-most minions.
									 //消灭对手场上最左边和最右边的随从。 
	{


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			List<Minion> minions = ownplay ? p.enemyMinions : p.ownMinions;
			int nums = minions.Count;
			switch (nums)
			{
				case 0:
					break;
				case 1:
					p.minionGetDestroyed(minions[0]);
					break;
				case 2:
					p.minionGetDestroyed(minions[0]);
					p.minionGetDestroyed(minions[1]);
					break;
				default:
					p.minionGetDestroyed(minions[0]);
					p.minionGetDestroyed(minions[nums - 1]);
					break;

			}
			}

		}
	}