using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_254 : SimTemplate //* 塞泰克织巢者 Sethekk Veilweaver
	{
		//[x]After you cast a spell ona minion, add a Priestspell to your hand.
		//在你对一个随从施放法术后，随机将一张牧师法术牌置入你的手牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
