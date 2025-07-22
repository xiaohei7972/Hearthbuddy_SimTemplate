using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_292b : SimTemplate //* 分流出击 Divide and Conquer
	{
		//Summon a copy of this_minion.
		//召唤一个该随从的复制。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 2),
            };
        }
	}
}
