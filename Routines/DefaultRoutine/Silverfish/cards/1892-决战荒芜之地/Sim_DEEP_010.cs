using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：4
	//Aftershocks
	//余震
	//Deal $1 damage to all minions, three times. Costs (1) less if you cast a spell last turn.
	//对所有随从造成$1点伤害，触发三次。如果你在上个回合施放过法术，则法力值消耗减少（1）点。
	class Sim_DEEP_010 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            // 对所有随从造成1点伤害，重复三次
            for (int i = 0; i < 3; i++)
            {
                foreach (Minion m in p.ownMinions)
                {
                    p.minionGetDamageOrHeal(m, p.getSpellDamageDamage(dmg));
                }

                foreach (Minion m in p.enemyMinions)
                {
                    p.minionGetDamageOrHeal(m, p.getSpellDamageDamage(dmg));
                }
            }
        }
    }
}
