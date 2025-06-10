using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_311b : SimTemplate //* 简单维修 Small Repairs
	{
		//Give a minion +2 Health and <b>Taunt</b>.
		//使一个随从获得+2生命值和<b>嘲讽</b>。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
