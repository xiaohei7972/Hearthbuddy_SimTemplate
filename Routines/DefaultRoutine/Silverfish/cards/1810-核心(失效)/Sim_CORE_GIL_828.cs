using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_CORE_GIL_828 : SimTemplate //* Dire Frenzy
    {
        // Give a Beast +3/+3. Shuffle 3 copies into your deck with +3/+3.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.minionGetBuffed(target, 3, 3);
			
            if (ownplay)
            {
                p.ownDeckSize += 3;
            }
            else
            {
                p.enemyDeckSize += 3;
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 20),
            };
        }
    }
}