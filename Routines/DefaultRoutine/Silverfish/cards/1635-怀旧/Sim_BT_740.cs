using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_740 : SimTemplate //* 灵魂裂劈 Soul Cleave
	{
		//<b>Lifesteal</b>Deal $2 damage to two random enemy minions.
		//<b>吸血</b>随机对两个敌方随从造成$2点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			int damage = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            List<Minion> temp2 = new List<Minion>(p.enemyMinions);
            temp2.Sort((a, b) => a.Hp.CompareTo(b.Hp));
            int i = 0;
            foreach (Minion enemy in temp2)
            {
				int oldHp = enemy.Hp;
                p.minionGetDamageOrHeal(enemy, damage);
				if (oldHp > enemy.Hp) p.applySpellLifesteal(oldHp - enemy.Hp, ownplay);
                i++;
                if (i == 2) break;
            }
        }		
		
	}
}
