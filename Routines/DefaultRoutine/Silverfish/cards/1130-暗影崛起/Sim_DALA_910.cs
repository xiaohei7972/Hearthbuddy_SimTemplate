using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_910 : SimTemplate //* 倾巢出动 The Gang's All Here!
	{
		//Choose a friendly minion. Add three new copies of it to your Adventure Deck.
		//选择一个友方随从，将它的三张全新复制加入你的冒险模式套牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
