using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_278t2 : SimTemplate //* 纯净药剂 Elixir of Purity
	{
		//Give a minion +2/+2 and <b>Divine Shield</b>.
		//使一个随从获得+2/+2和<b>圣盾</b>。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
