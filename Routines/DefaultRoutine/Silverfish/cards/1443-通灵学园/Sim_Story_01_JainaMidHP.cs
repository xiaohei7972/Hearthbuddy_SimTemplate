using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_01_JainaMidHP : SimTemplate //* 召唤元素 Summon Elemental
	{
		//<b>Hero Power</b>Summon a 3/6 Water Elemental.
		//<b>英雄技能</b>召唤一个3/6的水元素。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
