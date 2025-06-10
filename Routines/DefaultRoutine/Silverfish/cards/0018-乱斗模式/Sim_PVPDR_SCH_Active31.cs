using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active31 : SimTemplate //* 小袋钱币 Coin Pouch
	{
		//Summon a random 3-Cost minion. Upgrade this and shuffle it into your deck.
		//随机召唤一个法力值消耗为（3）的随从。将此牌升级并洗入你的牌库。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
