using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_039 : SimTemplate //* 活力图腾 Vitality Totem
//At the end of your turn, restore #4 Health to your hero.
//在你的回合结束时，为你的英雄恢复#4点生命值。 
    {

        

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                
                if (triggerEffectMinion.own)
                {
                    int heal = p.getMinionHeal(4);
                    p.minionGetDamageOrHeal(p.ownHero, -heal, true);
                }
                else
                {
                    int heal =  p.getEnemyMinionHeal(4);
                    p.minionGetDamageOrHeal(p.enemyHero, -heal, true);
                }

            }
        }


    }

}