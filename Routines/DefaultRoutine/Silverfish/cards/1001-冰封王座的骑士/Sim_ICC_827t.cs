using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_827t : SimTemplate //* 暗影映像 Shadow Reflection
//Each time you play a card, transform this into a copy of it.
//每当你使用一张牌，变形成为该卡牌的复制。 
    {
        

        

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
        {
            triggerhc.setHCtoHC(hc);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MUST_PLAY_OTHER_CARD_FIRST),
            };
        }
    }
}