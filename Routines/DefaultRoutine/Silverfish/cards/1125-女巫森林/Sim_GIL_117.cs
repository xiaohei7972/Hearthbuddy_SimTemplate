using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_117 : SimTemplate //* 狼人憎恶 Worgen Abomination
//At the end of your turn, deal 2 damage to all other damaged minions.
//在你的回合结束时，对所有其他受伤的随从造成2点伤害。 
	{
		

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int dmg = (turnEndOfOwner) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
				foreach (Minion m in p.ownMinions)
				{
					if (m.wounded) p.minionGetDamageOrHeal(m, dmg);
				}
				foreach (Minion m in p.enemyMinions)
				{
					if (m.wounded) p.minionGetDamageOrHeal(m, dmg);
				}
            }
        }
    }
}