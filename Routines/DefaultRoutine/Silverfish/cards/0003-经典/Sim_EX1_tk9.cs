using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_tk9 : SimTemplate //* 树人 Treant
	{
		//
		//


        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                p.minionGetDestroyed(triggerEffectMinion);
            }
        }

	}
}