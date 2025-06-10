using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA01_2H_2c_TB : SimTemplate //* 干杯！ Pile On!!!
//<b>Hero Power</b>Put two minions from your deck and one from your opponent's into the battlefield.
//<b>英雄技能</b>从你的牌库中将两个随从置入战场；对手将一个随从置入战场。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
