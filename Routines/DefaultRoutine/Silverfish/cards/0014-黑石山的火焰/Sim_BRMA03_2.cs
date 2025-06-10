using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA03_2 : SimTemplate //* 炎魔之王的力量 Power of the Firelord
//<b>Hero Power</b>Deal 30 damage.
//<b>英雄技能</b>造成30点伤害。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
