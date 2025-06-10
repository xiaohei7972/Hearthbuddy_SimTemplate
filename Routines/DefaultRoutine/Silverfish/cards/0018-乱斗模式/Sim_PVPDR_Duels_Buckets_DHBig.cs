using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_Duels_Buckets_DHBig : SimTemplate //* 数量压制 Overwhelm
	{
		//
		//
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
