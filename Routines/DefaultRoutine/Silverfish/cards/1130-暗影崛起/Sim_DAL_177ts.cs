using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_177ts : SimTemplate //* 咒术师的召唤 Conjurer's Calling
//Destroy a minion. Summon 2 minions of the same Cost to replace it.
//消灭一个随从。召唤两个法力值消耗相同的随从来替换它。 
	{



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            bool own = target.own;
            int place = target.zonepos;
            CardDB.Card d = target.handcard.card;
            p.minionGetDestroyed(target);
            p.callKid(d, place, own);
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