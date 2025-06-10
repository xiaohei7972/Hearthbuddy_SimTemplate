using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA07_2_2_TB : SimTemplate //* 猛砸 ME SMASH
//<b>Hero Power</b>Destroy a random enemy minion.
//<b>英雄技能</b>随机消灭一个敌方随从。 
	{
		
				
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			List<Minion> temp = (ownplay) ? new List<Minion>(p.enemyMinions) : new List<Minion>(p.ownMinions);
            temp.Sort((a, b) => a.Angr.CompareTo(b.Angr));
            foreach (Minion m in temp)
            {
				if(m.wounded)
				{
					p.minionGetDestroyed(m);
					break;
				}
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