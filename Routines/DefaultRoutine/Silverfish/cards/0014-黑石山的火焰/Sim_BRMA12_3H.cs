using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA12_3H : SimTemplate //* 龙血之痛：红 Brood Affliction: Red
//While this is in your hand, take 3 damage at the start of your turn.
//如果这张牌在你的手牌中，在你的回合开始时，你的英雄受到3点伤害。 
	{
		

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetDamageOrHeal(turnStartOfOwner ? p.ownHero : p.enemyHero, 3, true);
            }
        }
    }
}