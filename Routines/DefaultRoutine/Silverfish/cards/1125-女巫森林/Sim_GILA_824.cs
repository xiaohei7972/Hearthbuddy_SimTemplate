using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GILA_824 : SimTemplate //* 皇家礼包 Royal Gift
	{
		//Give a minion +2/+2 for each minion you control.
		//强化一个随从，你每有一个随从，便使其获得+2/+2。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
