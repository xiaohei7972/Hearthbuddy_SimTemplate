using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA09_4H : SimTemplate //* 黑翼 Blackwing
//<b>Hero Power</b>Summon a 5/4 Dragonkin. Get a new Hero Power.
//<b>英雄技能</b>召唤一个5/4的龙人。获得另一个英雄技能。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
