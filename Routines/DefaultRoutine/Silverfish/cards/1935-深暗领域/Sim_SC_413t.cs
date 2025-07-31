using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Siege Tank, Deployed
	//攻城坦克（已部署）
	//<b>Battlecry:</b> Deal 10 damage to a random enemy minion. Excess damage hits the enemy hero.
	//<b>战吼：</b>随机对一个敌方随从造成10点伤害。超过目标生命值的伤害会命中敌方英雄。
	class Sim_SC_413t : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{

			//默认找最高费的随从干掉
			Minion minion = p.searchRandomMinion(own.own ? p.enemyMinions : p.ownMinions, searchmode.searchHighesCost);
			if (minion != null)
			{
				p.minionGetDamageOrHeal(minion, 10);
				if (minion.Hp < 0)
				{
					p.minionGetDamageOrHeal(own.own ? p.enemyHero : p.ownHero, minion.Hp);
				}
			}
		}

	}
}
