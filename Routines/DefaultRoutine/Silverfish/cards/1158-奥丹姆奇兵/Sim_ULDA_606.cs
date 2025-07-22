using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_606 : SimTemplate //* 快去干活 Work, Work!
	{
		//[x]Remove a friendly minionfrom your Adventure Deck.Give adjacent minions +2/+2.
		//将一个友方随从移出你的冒险模式套牌。使相邻的随从获得+2/+2。
		
		

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
