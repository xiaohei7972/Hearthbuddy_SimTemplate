using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Toki_TimePortal : SimTemplate //* 通往未来！ Portal to the Future!
//Copy a minion. Fill next game's starting hand with it.
//复制一个随从。将该随从的复制置入你下一场对战的起始手牌，直到手牌数量达到上限。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
