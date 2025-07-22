using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_Priest_HP2 : SimTemplate //* 安抚 Soothe
	{
		//<b>Hero Power</b>Give a minion -2_Attack until your next turn.
		//<b>英雄技能</b>直到你的下个回合，使一个随从获得-2攻击力。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
