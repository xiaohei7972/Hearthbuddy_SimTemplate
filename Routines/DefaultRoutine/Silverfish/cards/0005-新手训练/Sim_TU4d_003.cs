using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TU4d_003 : SimTemplate //* 火枪轰击 Shotgun Blast
	{
		//<b>Hero Power</b>Deal 1 damage.
		//<b>英雄技能</b>造成1点伤害。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
