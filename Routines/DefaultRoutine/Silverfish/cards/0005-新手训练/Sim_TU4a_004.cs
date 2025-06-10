using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TU4a_004 : SimTemplate //* 霍格很厉害！ Hogger SMASH!
	{
		//Deal 4 damage.
		//造成4点伤害。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_HERO_TARGET),
            };
        }
	}
}
