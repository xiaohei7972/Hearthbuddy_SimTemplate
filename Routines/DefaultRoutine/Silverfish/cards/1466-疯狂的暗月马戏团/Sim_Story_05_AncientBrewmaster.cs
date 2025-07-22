using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_05_AncientBrewmaster : SimTemplate //* 年迈的酒仙 Ancient Brewmaster
	{
		//<b>Battlecry:</b> Return a friendly minion from the battlefield to your hand.
		//<b>战吼：</b>使一个友方随从从战场上移回你的手牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.minionReturnToHand(target, target.own, 0);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
            };
        }
	}
}
