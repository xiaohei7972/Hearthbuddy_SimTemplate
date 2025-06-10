using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_NAX8_03t : SimTemplate //* 鬼灵学徒 Spectral Trainee
//At the start of your turn, deal 1 damage to your hero.
//在你的回合开始时，对你的英雄造成1点伤害。 
    {
        

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
				p.minionGetDamageOrHeal(turnStartOfOwner ? p.ownHero : p.enemyHero, 1);
            }
        }

    }
}