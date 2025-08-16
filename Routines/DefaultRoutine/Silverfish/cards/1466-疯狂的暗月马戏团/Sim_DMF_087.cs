using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：5 攻击力：5 生命值：5
	//Trampling Rhino
	//狂踏的犀牛
	//<b>Rush</b>. After this attacksand kills a minion, excess damage hits the enemy hero.
	//<b>突袭</b>在本随从攻击并消灭一个随从后，超过目标生命值的伤害会命中敌方英雄。
	class Sim_DMF_087 : SimTemplate
	{
		public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
		{
			if (!defender.isHero && defender.Hp < 1)
			{
				p.minionGetDamageOrHeal(attacker.own ? p.enemyHero : p.ownHero,-attacker.Hp);
			}
		}
		
	}
}
