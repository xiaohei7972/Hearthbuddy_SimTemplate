using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NEW1_009 : SimTemplate //* 治疗图腾 Healing Totem
	{
		//At the end of your turn, restore #1 Health to all friendly minions.
		//在你的回合结束时，为所有友方随从恢复#1点生命值。

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int heal = (triggerEffectMinion.own) ? p.getMinionHeal(1) : p.getEnemyMinionHeal(1);
                p.allMinionOfASideGetDamage(turnEndOfOwner, -heal);
            }
        }

	}
}