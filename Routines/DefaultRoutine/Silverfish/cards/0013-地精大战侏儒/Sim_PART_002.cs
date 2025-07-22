using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_PART_002 : SimTemplate //* 时间回溯装置 Time Rewinder
//Return a friendly minion to your hand.
//将一个友方随从移回你的手牌。 
    {

        


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionReturnToHand(target, target.own, 0);
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }

}