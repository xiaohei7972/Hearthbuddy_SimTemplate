using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_614 : SimTemplate //* 巫毒娃娃 Voodoo Doll
//<b>Battlecry:</b> Choose a minion. <b>Deathrattle:</b> Destroy the chosen minion.
//<b>战吼：</b>选择一个随从。<b>亡语：</b>消灭选择的随从。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetDestroyed(target);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}