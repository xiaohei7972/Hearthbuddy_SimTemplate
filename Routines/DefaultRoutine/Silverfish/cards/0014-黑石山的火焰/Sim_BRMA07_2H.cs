using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA07_2H : SimTemplate //* 猛砸 ME SMASH
//<b>Hero Power</b>Destroy a random enemy minion.
//<b>英雄技能</b>随机消灭一个敌方随从。 
	{
		
				
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
		    Minion m = p.searchRandomMinion(ownplay ? p.enemyMinions : p.ownMinions, searchmode.searchLowestHP);
            if (m != null) p.minionGetDestroyed(m);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}