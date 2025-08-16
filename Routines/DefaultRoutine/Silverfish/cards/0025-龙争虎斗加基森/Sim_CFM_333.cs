using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：5 攻击力：3 生命值：7
	//Knuckles
	//金手指纳克斯
	//After this attacks aminion, it also hits the enemy hero.
	//在纳克斯攻击一名随从后，还会命中敌方英雄。
	class Sim_CFM_333 : SimTemplate
	{
		public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
		{
			if (!defender.isHero)
				p.minionAttacksMinion(attacker, attacker.own ? p.enemyHero : p.ownHero, true);
		}

	}
}
