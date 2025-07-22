using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BRMA09_6 : SimTemplate //* 真正的酋长 The True Warchief
//Destroy a Legendary minion.
//消灭一个传说随从 
    {
        
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (target != null) p.minionGetDestroyed(target);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_LEGENDARY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}