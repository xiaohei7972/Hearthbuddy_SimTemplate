using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOEA07_28 : SimTemplate //* 修理 Repairs
//Restore #10 Health.
//恢复#10点生命值。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
