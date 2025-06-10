using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_025 : SimTemplate //* 转生 Reincarnate
//Destroy a minion, then return it to life with full Health.
//消灭一个随从，然后将其复活，并具有所有生命值。 
	{



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            bool own = target.own;
            int place = target.zonepos;
            CardDB.Card d = target.handcard.card;
            p.minionGetDestroyed(target);
            p.callKid(d, place, own);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}