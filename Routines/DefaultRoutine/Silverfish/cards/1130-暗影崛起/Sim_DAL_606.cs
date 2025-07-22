using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_606: SimTemplate //* 怪盗天才 EVIL Genius
//<b>Battlecry:</b> Destroy a friendly minion to add 2 random <b>Lackeys</b>_to_your_hand.
//<b>战吼：</b>消灭一个友方随从，随机将两张<b>跟班</b>牌置入你的手牌。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetDestroyed(target);
                p.drawACard(CardDB.cardNameEN.unknown, own.own);
				p.drawACard(CardDB.cardNameEN.unknown, own.own);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}