using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_025 : SimTemplate //* 黑暗交易 Dark Bargain
//Destroy 2 random enemy minions. Discard 2 random cards.
//随机消灭两个敌方随从，随机弃两张牌。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? new List<Minion>(p.enemyMinions) : new List<Minion>(p.ownMinions);
			if (temp.Count >= 2)
			{
				temp.Sort((a, b) => a.Angr.CompareTo(b.Angr));
				bool enough = false;
				foreach (Minion enemy in temp)
				{
					p.minionGetDestroyed(enemy);
					if (enough) break;
					enough = true;
				}
                p.discardCards(2, ownplay);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}
