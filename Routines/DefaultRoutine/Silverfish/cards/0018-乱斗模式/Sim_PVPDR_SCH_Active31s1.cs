using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active31s1 : SimTemplate //* 中袋钱币 Sack of Coins
	{
		//Summon a random 6-Cost minion. Upgrade this and shuffle it into your deck.
		//随机召唤一个法力值消耗为（6）的随从。将此牌升级并洗入你的牌库。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
