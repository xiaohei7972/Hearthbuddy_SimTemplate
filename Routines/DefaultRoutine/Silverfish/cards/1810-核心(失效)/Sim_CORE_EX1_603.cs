using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_CORE_EX1_603 : SimTemplate //* Cruel Taskmaster
	{
        // Battlecry: Deal 1 damage to a minion and give it +2 

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, 1);
                p.minionGetBuffed(target, 2, 0);
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
            };
        }
	}
}