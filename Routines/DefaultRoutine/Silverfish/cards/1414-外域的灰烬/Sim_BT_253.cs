using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_253 : SimTemplate //* 心灵分裂 Psyche Split
	{
		//Give a minion +1/+2. Summon a copy of it.
		//使一个随从获得+1/+2，并召唤一个它的复制。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
