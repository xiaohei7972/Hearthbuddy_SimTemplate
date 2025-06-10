using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_278t1 : SimTemplate //* 生命药剂 Elixir of Life
	{
		//Give a minion +2/+2 and <b>Lifesteal</b>.
		//使一个随从获得+2/+2和<b>吸血</b>。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
