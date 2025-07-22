using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_03_JainaHP : SimTemplate //* 召唤元素 Summon Elemental
	{
		//<b>Hero Power</b>Summon a 5/8 Water Elemental.
		//<b>英雄技能</b>召唤一个5/8的水元素。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
