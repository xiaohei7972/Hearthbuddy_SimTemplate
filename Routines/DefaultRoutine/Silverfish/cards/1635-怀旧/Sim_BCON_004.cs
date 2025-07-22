using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BCON_004 : SimTemplate //* 变形术：?? Polymorph: ???
	{
		//Choose a minion. <b>Discover</b> a new minion to transform it into.
		//选择一个随从，将其变形成为你<b>发现</b>的一个新随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
