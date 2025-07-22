using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_271 : SimTemplate //* 梦魇之龙 Scaled Nightmare
//At the start of your turn, double this minion's Attack.
//在你的回合开始时，该随从的攻击力翻倍。 
	{
		
		
		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion, 2 * triggerEffectMinion.Angr, 0);
            }
        }
	}
}