using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ICCA04_011p : SimTemplate //* 寒冰爪 Ice Claw
//<b>Hero Power</b>Deal $2 damage.
//<b>英雄技能</b>造成$2点伤害。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
