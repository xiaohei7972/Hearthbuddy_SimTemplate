using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRGA_BOSS_02t3 : SimTemplate //* 抗击怪盗 Stand Against E.V.I.L.
	{
		//Choose a minion. Summon three 2/2 Treants that attack it.
		//选择一个随从。召唤三个2/2的树人攻击该随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
