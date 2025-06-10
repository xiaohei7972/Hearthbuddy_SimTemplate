using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ICCA08_026 : SimTemplate //* 灵魂收割 Soul Reaper
	{
		//Deal $2 damage for each duplicate in opponent’s deck.
		//你对手的牌库中每有一张相同的卡牌，便造成$2点伤害。

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
