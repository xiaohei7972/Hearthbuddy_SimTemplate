using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_508 : SimTemplate //* 再生暴徒 Regeneratin' Thug
//At the start of your turn, restore #2 Health to this_minion.
//在你的回合开始时，为该随从恢复#2点生命值。 
	{



        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                int heal = (triggerEffectMinion.own) ? p.getMinionHeal(2) : p.getEnemyMinionHeal(2);
                p.minionGetDamageOrHeal(triggerEffectMinion, -heal);
            }
        }

	}
}