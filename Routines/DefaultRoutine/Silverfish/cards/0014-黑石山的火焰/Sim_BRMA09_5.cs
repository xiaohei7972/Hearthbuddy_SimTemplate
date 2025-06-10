using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA09_5 : SimTemplate //* 跃下坐骑 Dismount
//<b>Hero Power</b>Summon Gyth. Get a new Hero Power.
//<b>英雄技能</b>召唤盖斯。获得另一个英雄技能。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
