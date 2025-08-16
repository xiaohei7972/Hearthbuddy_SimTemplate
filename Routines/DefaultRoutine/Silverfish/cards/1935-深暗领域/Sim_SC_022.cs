using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：4 攻击力：5 生命值：2
	//Mutalisk
	//异龙
	//[x]Also damages minions nextto whomever this attacks<i>(and the enemy hero if aneighbor is missing)</i>.
	//同时对其攻击目标相邻的随从造成伤害<i>（如果某侧没有相邻随从，还会命中敌方英雄）</i>。
	class Sim_SC_022 : SimTemplate
	{
		public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
		{
			int attackminions = 2;
			List<Minion> temp = (attacker.own) ? p.enemyMinions : p.ownMinions;
			foreach (Minion mnn in temp)
			{
				if (mnn.zonepos + 1 == defender.zonepos || mnn.zonepos - 1 == defender.zonepos)
				{
					p.minionAttacksMinion(attacker, mnn, true);
					attackminions--;
				}
			}
			
			if (attackminions > 0)
			{
				p.minionAttacksMinion(attacker, attacker.own ? p.enemyHero : p.ownHero, true);
			}
		}

	}
}
