using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_609 : SimTemplate //* 邪兽人噬魂魔 Fel Orc Soulfiend
//At the start of your turn, deal 2 damage to this_minion.
//在你的回合开始时，对该随从造成2点伤害。 
	{
		

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetDamageOrHeal(triggerEffectMinion, 2);
            }
        }
    }
}