using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_112 : SimTemplate //* 鲍勃的保镖 Bob's Bouncer
	{
		//[x]Choose a minionand then cast 'Brawl.'If that minion survives, fillyour board with copies of it.
		//选择一个随从，然后施放“绝命乱斗”。如果该随从最终存活，则召唤它的数个复制，直到你的随从数量达到上限。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 2),
            };
        }
	}
}
