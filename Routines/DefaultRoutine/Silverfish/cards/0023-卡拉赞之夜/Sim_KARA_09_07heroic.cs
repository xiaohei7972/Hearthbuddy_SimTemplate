using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KARA_09_07heroic : SimTemplate //* 生命窃取 Steal Life
//Deal $5 damage. Restore #5 Health to your hero.
//造成$5点伤害。为你的英雄恢复#5点生命值。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
