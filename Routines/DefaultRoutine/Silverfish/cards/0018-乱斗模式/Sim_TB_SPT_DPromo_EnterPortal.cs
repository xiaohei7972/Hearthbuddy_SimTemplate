using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_SPT_DPromo_EnterPortal : SimTemplate //* 开启传送门 The Portal Opens
//Through the Nether and into...
//我从虚空中来… 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
