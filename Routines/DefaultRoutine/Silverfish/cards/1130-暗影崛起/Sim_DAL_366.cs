using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_366 : SimTemplate //* 未鉴定的合约 Unidentified Contract
//Destroy a minion. Gains a bonus effect in_your hand.
//消灭一个随从。在你手牌中时获得额外效果。 
	{
		


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}