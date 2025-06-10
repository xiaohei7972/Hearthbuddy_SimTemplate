using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ICCA08_002p : SimTemplate //* 天灾军团 The Scourge
//<b>Hero Power</b>Summon a 2/2 Ghoul.
//<b>英雄技能</b>召唤一个2/2的食尸鬼。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
