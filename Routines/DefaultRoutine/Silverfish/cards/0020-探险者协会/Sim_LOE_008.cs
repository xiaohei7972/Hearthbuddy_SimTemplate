using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_008 : SimTemplate //* 哈卡之眼 Eye of Hakkar
//Take a secret from your opponent's deck and put it into the battlefield.
//攫取你对手的牌库中的一个奥秘，并将其置入战场。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
