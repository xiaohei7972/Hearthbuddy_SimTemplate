using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA12_4H : SimTemplate //* 龙血之痛：绿 Brood Affliction: Green
//While this is in your hand, restore #6 health to your opponent at the start of your turn.
//如果这张牌在你的手牌中，在你的回合开始时，敌方英雄恢复#6点生命值。 
	{
		

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetDamageOrHeal(turnStartOfOwner ? p.ownHero : p.enemyHero, -6, true);
            }
        }
    }
}