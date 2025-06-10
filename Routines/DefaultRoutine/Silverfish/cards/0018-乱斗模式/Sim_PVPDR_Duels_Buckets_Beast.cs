using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_Duels_Buckets_Beast : SimTemplate //* 野兽之心 Beasts
	{
		//
		//
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 20),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
