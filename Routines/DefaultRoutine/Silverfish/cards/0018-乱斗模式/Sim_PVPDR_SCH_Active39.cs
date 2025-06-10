using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active39 : SimTemplate //* 粗鄙的暴徒 Surly Mob
	{
		//Destroy a random enemy minion. Upgrade this and shuffle it into your deck.
		//随机消灭一个敌方随从。将此牌升级并洗入你的牌库。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}
