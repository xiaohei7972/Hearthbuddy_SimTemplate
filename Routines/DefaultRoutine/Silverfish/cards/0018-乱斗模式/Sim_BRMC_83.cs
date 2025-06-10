using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMC_83 : SimTemplate //* 打开大门 Open the Gates
	{
		//Fill your board with 2/2 Whelps.
		//召唤数条2/2的雏龙，直到你的随从数量达到上限。
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
