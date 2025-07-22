using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_01_LibramofWisdom : SimTemplate //* 智慧圣契 Libram of Wisdom
	{
		//[x]Give a minion +1/+1and "<b>Deathrattle:</b> Adda 'Libram of Wisdom'spell to your hand."
		//使一个随从获得+1/+1，以及“<b>亡语：</b>将一张‘智慧圣契’法术牌置入你的手牌。”
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
