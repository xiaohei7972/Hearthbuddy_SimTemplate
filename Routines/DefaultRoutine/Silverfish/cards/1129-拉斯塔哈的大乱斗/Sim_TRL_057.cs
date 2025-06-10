using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_057 : SimTemplate //* 毒蛇守卫 Serpent Ward
//At the end of your turn,deal 2 damage to the enemy hero.
//在你的回合结束时，对敌方英雄造成2点伤害。 
    {

        

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                
                if (triggerEffectMinion.own)
                {
                    int dmg = p.getMinionHeal(2);
                    p.minionGetDamageOrHeal(p.enemyHero, dmg, true);
                }
                else
                {
                    int dmg =  p.getEnemyMinionHeal(2);
                    p.minionGetDamageOrHeal(p.ownHero, dmg, true);
                }

            }
        }


    }

}