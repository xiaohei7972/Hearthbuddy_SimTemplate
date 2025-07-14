using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
			int damage = ownplay ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
			for (int i = 0; i < 2; i++)
			{
				List<Minion> minions = ownplay ? p.enemyMinions.ToList() : p.ownMinions.ToList();
				if (ownplay)
				{
					minions.Add(p.enemyHero);
				}
				else
				{
					minions.Add(p.ownHero);
				}
				p.minionGetDamageOrHeal(p.searchRandomMinion(minions, searchmode.searchLowestHP), damage);
				p.applySpellLifesteal(damage, ownplay);
			}

		}

	}
}
