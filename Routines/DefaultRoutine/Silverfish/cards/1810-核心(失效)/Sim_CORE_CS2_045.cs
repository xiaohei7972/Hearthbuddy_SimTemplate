using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_CS2_045 : SimTemplate //rockbiterweapon
	{

//    verleiht einem befreundeten charakter +3 angriff in diesem zug.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetTempBuff(target, 3,0);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}