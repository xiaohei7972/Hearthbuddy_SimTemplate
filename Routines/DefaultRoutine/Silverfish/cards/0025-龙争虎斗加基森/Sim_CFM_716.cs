using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_716 : SimTemplate //* 鱼死网破 Sleep with the Fishes
//Deal $3 damage to all damaged minions.
//对所有受伤的随从造成$3点伤害。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
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