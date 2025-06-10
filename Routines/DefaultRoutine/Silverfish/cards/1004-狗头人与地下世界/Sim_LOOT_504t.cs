using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_504t : SimTemplate //* 不稳定的异变 Unstable Evolution
	{
		//Transform a friendly minion intoone that costs (1) more. Repeatable this turn.
		//将一个友方随从随机变形成为一个法力值消耗增加（1）点的随从。在本回合可以重复使用。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
