using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_809: SimTemplate //* 瘟疫科学家 Plague Scientist
//<b>Combo:</b> Give a friendly minion <b>Poisonous</b>.
//<b>连击：</b>使一个友方随从获得<b>剧毒</b>。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (p.cardsPlayedThisTurn >= 1 && target != null && own.own)
            {
                target.poisonous = true;
            }
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