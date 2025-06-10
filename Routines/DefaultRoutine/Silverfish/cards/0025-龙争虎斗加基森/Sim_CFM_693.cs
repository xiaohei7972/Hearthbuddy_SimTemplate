using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_693 : SimTemplate //* 加基森摆渡人 Gadgetzan Ferryman
//<b>Combo:</b> Return a friendly minion to your hand.
//<b>连击：</b>将一个友方随从移回你的手牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (p.cardsPlayedThisTurn > 0 && target != null) p.minionReturnToHand(target, target.own, 0);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_FOR_COMBO),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}