using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_654 : SimTemplate //* 热心的酒保 Friendly Bartender
//At the end of your turn, restore #1 Health to your_hero.
//在你的回合结束时，为你的英雄恢复#1点生命值。 
	{
		

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {

                if (triggerEffectMinion.own)
                {
                    int heal = p.getMinionHeal(1);
                    p.minionGetDamageOrHeal(p.ownHero, -heal, true);
                }
                else
                {
                    int heal = p.getEnemyMinionHeal(1);
                    p.minionGetDamageOrHeal(p.enemyHero, -heal, true);
                }
            }
        }
    }
}