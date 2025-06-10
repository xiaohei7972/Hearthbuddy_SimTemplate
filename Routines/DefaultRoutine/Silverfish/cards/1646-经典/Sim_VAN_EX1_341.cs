using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_341 : SimTemplate //* 光明之泉 Lightwell
	{
		//At the start of your turn, restore #3 Health to a damaged friendly character.
		//在你的回合开始时，随机为一个受伤的友方角色恢复#3点生命值。

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (turnStartOfOwner == triggerEffectMinion.own)
            {
                int heal = (turnStartOfOwner) ? p.getMinionHeal(3) : p.getEnemyMinionHeal(3);
                List<Minion> temp = (turnStartOfOwner) ? p.ownMinions : p.enemyMinions;
                if (temp.Count >= 1)
                {
                    bool healed = false;
                    foreach (Minion mins in temp)
                    {
                        if (mins.wounded)
                        {
                            p.minionGetDamageOrHeal(mins, -heal);
                            healed = true;
                            break;
                        }
                    }

                    if (!healed)
                    {
                        p.minionGetDamageOrHeal(turnStartOfOwner ? p.ownHero : p.enemyHero, -heal);
                    }
                }
                else
                {
                    p.minionGetDamageOrHeal(turnStartOfOwner ? p.ownHero : p.enemyHero, -heal);
                }

            }
        }
    }
}
