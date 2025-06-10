using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_099 : SimTemplate //* 我找到了 Eureka!
	{
		//Summon a copy of_a_random minion from your hand.
		//随机召唤你手牌中的一张随从牌的一个复制。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
