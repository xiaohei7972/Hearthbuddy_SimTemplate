using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_278t4 : SimTemplate //* 希望药剂 Elixir of Hope
	{
		//[x]Give a minion +2/+2and "<b>Deathrattle:</b> Returnthis minion to your hand."
		//使一个随从获得+2/+2，以及“<b>亡语：</b>将该随从移回你的手牌。”
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
