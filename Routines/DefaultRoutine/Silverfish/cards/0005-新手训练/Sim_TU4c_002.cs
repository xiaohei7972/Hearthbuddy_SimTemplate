using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TU4c_002 : SimTemplate //* 掷桶 Barrel Toss
	{
		//Deal 2 damage.
		//造成2点伤害。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
