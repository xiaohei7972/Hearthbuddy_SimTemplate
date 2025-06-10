using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_CORE_EX1_059 : SimTemplate //* Crazed Alchemist
	{
        // Battlecry: Swap the Attack and Health of a minion.

		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
            if (target != null) p.minionSwapAngrAndHP(target);
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