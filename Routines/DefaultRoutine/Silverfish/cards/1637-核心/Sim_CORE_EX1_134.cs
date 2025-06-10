using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_EX1_134 : SimTemplate //* si7agent
	{
        // Combo:: Deal 2 damage.

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.cardsPlayedThisTurn >= 1 && target != null)
            {
                p.minionGetDamageOrHeal(target, 2);
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_FOR_COMBO),
            };
        }
	}
}