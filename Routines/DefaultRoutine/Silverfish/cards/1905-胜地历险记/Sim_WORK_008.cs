using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：4
	//Fine Print
	//合约细则
	//Deal $4 damage to all_minions.<i>(Excess damage hits your_hero.)</i>
	//对所有随从造成$4点伤害。<i>（超过其生命值的伤害会命中你的英雄。）</i>
	class Sim_WORK_008 : SimTemplate
	{
		/*
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
			List<Minion> minions = p.ownMinions.ToList();
			minions.AddRange(p.enemyMinions.ToList());
			foreach (Minion m in minions)
			{
				int excessDamage = damage - target.Hp > 0 ? damage - target.Hp : 0;
				p.minionGetDamageOrHeal(m, damage, true);
				if (excessDamage > 0)
				{
					p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, excessDamage);
				}
			}
		}
		*/

	}
}
