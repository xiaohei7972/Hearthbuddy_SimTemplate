using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_007t : SimTemplate //* 诅咒 Cursed!
//While this is in your hand, take 2 damage at the start of your turn.
//如果这张牌在你的手牌中，在你的回合开始时，你的英雄受到2点伤害。 
	{
		

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetDamageOrHeal(turnStartOfOwner ? p.ownHero : p.enemyHero, 2, true);
            }
        }
    }
}