using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_027 : SimTemplate //* 岩肤石像鬼 Stoneskin Gargoyle
//At the start of your turn, restore this minion to full Health.
//在你的回合开始时，为该随从恢复所有生命值。 
	{



        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                int heal = (triggerEffectMinion.own) ? p.getMinionHeal(triggerEffectMinion.maxHp - triggerEffectMinion.Hp) : p.getEnemyMinionHeal(triggerEffectMinion.maxHp - triggerEffectMinion.Hp);
                p.minionGetDamageOrHeal(triggerEffectMinion, -heal);
            }
        }

	}
}