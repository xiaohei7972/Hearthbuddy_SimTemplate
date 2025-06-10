using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BCON_016 : SimTemplate //* 烟雾弹 Smoke Bomb
	{
		//Give a minion <b>Stealth</b> until your next turn. Draw a card.
		//直到你的下个回合，使一个随从获得<b>潜行</b>。抽一张牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
