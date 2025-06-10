using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_EX1_005 : SimTemplate //biggamehunter
	{

//    kampfschrei:/ vernichtet einen diener mit mind. 7 angriff.
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target != null) p.minionGetDestroyed(target);
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_MIN_ATTACK, 7),
            };
        }
	}
}