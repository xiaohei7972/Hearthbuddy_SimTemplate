using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：3
	//Lava Flow
	//熔岩涌流
	//Deal $2 damage to the lowest Health enemy, three times. <b>Overload:</b> (1)
	//对生命值最低的敌人造成$2点伤害，触发三次。<b>过载：</b>（1）。
	class Sim_TLC_227 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			for (int i = 0; i < 3; i++)
			{
				int damage = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
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
			}

			if (ownplay) p.ueberladung++;

		}

	}
}
