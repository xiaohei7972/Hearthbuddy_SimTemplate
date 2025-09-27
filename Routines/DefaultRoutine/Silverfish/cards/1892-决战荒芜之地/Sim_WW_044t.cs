using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：3
	//Barrel of Sludge
	//淤泥桶
	//When this is played, discarded, or destroyed, deal $4 damage to the lowest Health enemy.
	//当本牌被使用，弃掉或摧毁时，对生命值最低的敌人造成$4点伤害。
	class Sim_WW_044t : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
			List<Minion> minions = ownplay ? p.enemyMinions : p.ownMinions;
			if (ownplay) minions.Add(p.enemyHero);
			else minions.Add(p.ownHero);
			Minion minion = p.searchRandomMinion(minions, searchmode.searchLowestHP);
			if (minion != null)
			{
				p.minionGetDamageOrHeal(minion, damage);
			}
		}

	}
}
