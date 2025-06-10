using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_tk33_2_TB : SimTemplate //* 地狱火！ INFERNO!
//<b>Hero Power</b>Summon a 6/6 Infernal.
//<b>英雄技能</b>召唤一个6/6的地狱火。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
