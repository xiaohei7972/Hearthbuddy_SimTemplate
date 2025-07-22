using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：3
	//Rising Waves
	//浪潮涌起
	//Deal $2 damage to all minions. If none die, deal $2 more.
	//对所有随从造成$2点伤害。如果没有随从死亡，再造成$2点。
	class Sim_VAC_953 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            bool minionDied = false;

            // 对所有随从造成2点伤害
            foreach (Minion m in p.ownMinions)
            {
                p.minionGetDamageOrHeal(m, damage);
                if (m.Hp <= 0) minionDied = true;
            }

            foreach (Minion m in p.enemyMinions)
            {
                p.minionGetDamageOrHeal(m, damage);
                if (m.Hp <= 0) minionDied = true;
            }

            // 如果没有随从死亡，再造成2点伤害
            if (!minionDied)
            {
                foreach (Minion m in p.ownMinions)
                {
                    p.minionGetDamageOrHeal(m, damage);
                }

                foreach (Minion m in p.enemyMinions)
                {
                    p.minionGetDamageOrHeal(m, damage);
                }
            }
        }


    }
}
