using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active31s2 : SimTemplate //* 大袋钱币 Hefty Sack of Coins
	{
		//Summon a random 3, 6, and 9-Cost minion.
		//随机召唤一个法力值消耗为（3）、（6）和（9）的随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
