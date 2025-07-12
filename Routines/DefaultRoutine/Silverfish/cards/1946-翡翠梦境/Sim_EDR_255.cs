using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：7
	//Renewing Flames
	//复苏烈焰
	//<b>Lifesteal</b>. Deal $5 damage to the lowest Health enemy, twice.
	//<b>吸血</b>。对生命值最低的敌人造成$5点伤害，触发两次。
	class Sim_EDR_255 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			for (int i = 0; i < 2; i++)
			{
				int damage = ownplay ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
				List<Minion> minions = ownplay ? p.enemyMinions : p.ownMinions;
				if (ownplay)
				{
					minions.Add(p.enemyHero);
				}
				else
				{
					minions.Add(p.ownHero);
				}
				Minion target1 = p.searchRandomMinion(minions, searchmode.searchLowestHP);
				p.minionGetDamageOrHeal(target1, damage);
				p.applySpellLifesteal(damage, ownplay);
			}

		}
		
	}
}
