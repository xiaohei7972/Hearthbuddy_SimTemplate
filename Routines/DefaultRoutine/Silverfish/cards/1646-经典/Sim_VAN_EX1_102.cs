using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_102 : SimTemplate //* 攻城车 Demolisher
	{
		//At the start of your turn, deal 2 damage to a random enemy.
		//在你的回合开始时，随机对一个敌人造成2点伤害。
        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                List<Minion> temp2 = (turnStartOfOwner) ? p.enemyMinions : p.ownMinions;
                bool dmgdone = false;
                foreach (Minion mins in temp2)
                {
                    p.minionGetDamageOrHeal(mins, 2);
                    dmgdone = true;
                    break;
                }
                if (!dmgdone)
                {
                    p.minionGetDamageOrHeal(turnStartOfOwner ? p.enemyHero : p.ownHero, 2);
                };
            }
        }

    }
}