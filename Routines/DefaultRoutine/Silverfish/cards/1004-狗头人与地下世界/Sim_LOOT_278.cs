using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_278 : SimTemplate //* 未鉴定的药剂 Unidentified Elixir
	{
		//Give a minion +2/+2. Gains a bonus effect in_your hand.
		//使一个随从获得+2/+2。在你手牌中时获得额外效果。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
