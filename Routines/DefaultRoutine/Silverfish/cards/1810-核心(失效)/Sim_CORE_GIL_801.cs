using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_GIL_801 : SimTemplate //* 急速冷冻
	{
		//冻结一个随从。如果该随从已被冻结，则将其消灭.
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target.frozen)
            {
                p.minionGetDestroyed(target);
            }
            else
            {
                p.minionGetFrozen(target);
            }
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