using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_BRMA01_2H_2 : SimTemplate //* 干杯！ Pile On!!!
//<b>Hero Power</b>Put a minion from each deck into the battlefield.
//<b>英雄技能</b>从双方的牌库中各将一个随从置入战场。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
