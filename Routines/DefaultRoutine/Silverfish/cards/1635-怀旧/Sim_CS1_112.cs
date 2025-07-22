using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS1_112 : SimTemplate //* 神圣新星 Holy Nova
	{
		//Deal $2 damage to all enemy minions. Restore #2 Health to all friendly characters.
		//对所有敌方随从造成$2点伤害，为所有友方角色恢复#2点生命值。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay)? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            int heal = (ownplay) ? p.getSpellHeal(2) : p.getEnemySpellHeal(2) ;
            if (ownplay)
            {
                p.minionGetDamageOrHeal(p.ownHero, -heal);
                p.minionGetDamageOrHeal(p.enemyHero, dmg);
                foreach (Minion m in p.ownMinions)
                {
                    p.minionGetDamageOrHeal(m, -heal);
                }

                foreach (Minion m in p.enemyMinions)
                {
                    p.minionGetDamageOrHeal(m, dmg);
                }
            }
            else 
            {
                p.minionGetDamageOrHeal(p.enemyHero, -heal);
                p.minionGetDamageOrHeal(p.ownHero, dmg);
                foreach (Minion m in p.enemyMinions)
                {
                    p.minionGetDamageOrHeal(m, -heal);
                }

                foreach (Minion m in p.ownMinions)
                {
                    p.minionGetDamageOrHeal(m, dmg);
                }
            }
        }

    }
}
