using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_278t3 : SimTemplate //* 暗影药剂 Elixir of Shadows
	{
		//Give a minion +2/+2. Summon a 1/1 copy of_it.
		//使一个随从获得+2/+2，并召唤一个1/1复制。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
