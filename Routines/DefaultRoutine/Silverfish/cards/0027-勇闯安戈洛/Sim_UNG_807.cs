using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_807 : SimTemplate //* 葛拉卡爬行蟹 Golakka Crawler
//<b>Battlecry:</b> Destroy a Pirate and gain +1/+1.
//<b>战吼：</b>消灭一个海盗，并获得+1/+1。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetDestroyed(target);
                p.minionGetBuffed(own, 1, 1);
            }
        } 

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 23),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
