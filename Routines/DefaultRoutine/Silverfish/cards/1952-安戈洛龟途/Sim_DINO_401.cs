using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：8 攻击力：5 生命值：12
	//The Great Dracorex
	//伟岸的德拉克雷斯
	//[x]<b>Rush</b>After this attacks an enemyminion, it damages ALLother enemy minions.
	//<b>突袭</b>。在本随从攻击一个敌方随从后，还会对所有其他敌方随从造成伤害。
	class Sim_DINO_401 : SimTemplate
	{
        public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
        {
			if (!defender.isHero)
			{
				foreach (Minion minion in attacker.own ? p.enemyMinions : p.ownMinions)
				{
					if (minion.entitiyID == defender.entitiyID) continue;
					p.minionGetDamageOrHeal(minion, attacker.Angr);
					// p.minionAttacksMinion(attacker, minion, true);
				}
			}
        }
		
	}
}
