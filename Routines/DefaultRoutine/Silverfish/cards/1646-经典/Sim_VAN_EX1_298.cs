using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_VAN_EX1_298 : SimTemplate //* Ragnaros the Firelord
    {
        // Can't Attack. At the end of your turn, deal 8 damage to a random enemy.

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                Minion target = null;

                if (turnEndOfOwner)
                {
                    target = p.enemyHero;
                    if(p.enemyMinions.Count > 0)
                    {
                        target = p.enemyMinions[0];
                    }
                }
                else
                {
                    target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); //damage the Highest (pessimistic)
                    if (target == null) target = p.ownHero;
                }
                p.minionGetDamageOrHeal(target, 8, true);
                triggerEffectMinion.stealth = false;
            }
        }
    }
}