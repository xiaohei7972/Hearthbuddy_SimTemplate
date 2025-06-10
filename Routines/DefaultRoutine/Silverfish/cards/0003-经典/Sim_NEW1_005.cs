using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NEW1_005 : SimTemplate //* 劫持者 Kidnapper
	{
		//<b>Combo:</b> Return a minion to_its owner's hand.
		//<b>连击：</b>将一个随从移回其拥有者的手牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.cardsPlayedThisTurn >= 1) p.minionReturnToHand(target,target.own, 0);
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_FOR_COMBO),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}