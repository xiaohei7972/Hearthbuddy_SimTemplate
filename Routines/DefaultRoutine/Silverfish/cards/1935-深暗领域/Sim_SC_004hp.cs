using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 无效的 费用：2
	//Ravage
	//毁灭跳击
	//[x]Deal $@ damage randomlysplit among all enemies.<i>(Improved by Zerg minionsyou control!)</i>
	//造成$@点伤害，随机分配到所有敌人身上。<i>（你每控制一个异虫随从都会提升！）</i>
	class Sim_SC_004hp : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int damage = ownplay ? p.getHeroPowerDamage(3) : p.getEnemyHeroPowerDamage(3);
			List<Minion> minions = ownplay ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in minions)
			{
				if (minion.handcard.card.Zerg)
					damage++;
			}
			p.allCharsOfASideGetRandomDamage(!ownplay,damage);
		}

	}
}
