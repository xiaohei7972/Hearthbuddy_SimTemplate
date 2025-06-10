using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_601 : SimTemplate //* 成员更替 Hiring Replacements
	{
		//[x]Choose a friendly minion.<b>Discover</b> a minionto replace it in your Adventure Deck.
		//选择一个友方随从。<b>发现</b>一个随从来将其替换出你的冒险模式套牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
