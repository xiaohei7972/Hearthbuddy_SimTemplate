using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_LOOT_017 : SimTemplate //* 黑暗契约 Dark Pact
//Destroy a friendly minion. Restore #8 Health to your hero.
//消灭一个友方随从。为你的英雄恢复#8点生命值。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
