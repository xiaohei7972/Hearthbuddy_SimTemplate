using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ICCA05_004p : SimTemplate //* 吸血之噬 Vampiric Leech
//<b>Hero Power</b><b>Lifesteal</b>Deal $3 damage.
//<b>英雄技能</b><b>吸血</b>，造成$3点伤害。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
