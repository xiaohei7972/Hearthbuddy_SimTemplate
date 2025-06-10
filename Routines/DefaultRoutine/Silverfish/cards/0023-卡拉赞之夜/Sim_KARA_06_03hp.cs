using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KARA_06_03hp : SimTemplate //* 真爱无敌 True Love
//<b>Hero Power</b>If you don't have Romulo, summon him.
//<b>英雄技能</b>如果罗密欧不在场，则召唤他。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
