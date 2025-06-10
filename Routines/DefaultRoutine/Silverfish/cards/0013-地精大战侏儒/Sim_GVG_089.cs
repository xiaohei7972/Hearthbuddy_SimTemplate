using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_089 : SimTemplate //* 明光祭司 Illuminator
//If you control a <b>Secret</b> at the end of your turn, restore #4 Health to your hero.
//如果在你的回合结束时，你控制一个<b>奥秘</b>，则为你的英雄恢复#4点生命值。 
    {

        

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                if (((turnEndOfOwner) ? p.ownSecretsIDList.Count : p.enemySecretList.Count) >= 1)
                {
                    int heal = (turnEndOfOwner) ? p.getMinionHeal(4) : p.getEnemyMinionHeal(4);
                    p.minionGetDamageOrHeal(((turnEndOfOwner) ? p.ownHero : p.enemyHero), -heal, true);
                }
            }
        }

    }

}