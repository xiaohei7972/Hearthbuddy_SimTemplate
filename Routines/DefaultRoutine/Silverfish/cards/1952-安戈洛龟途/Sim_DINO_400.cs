using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：3 攻击力：4 生命值：3
	//Barricade Basher
	//怒袭甲龙
	//[x]Whenever you gain Armor, gain +2/+2 and attack arandom enemy minion.
	//每当你获得护甲值，获得+2/+2并随机攻击一个敌方随从。
	class Sim_DINO_400 : SimTemplate
	{
		public override void onHeroGetArmor(Playfield p, Minion triggerMinion, bool ownHero, int armor)
		{
			p.minionGetBuffed(triggerMinion, 2, 2);
			List<Minion> minions = triggerMinion.own ? p.enemyMinions : p.ownMinions;
			if (minions.Count > 0)
			{
				int index = p.getRandomNumber(0, minions.Count - 1);
				Minion target = minions[index];
				if (target != null)
				{
					p.minionAttacksMinion(triggerMinion, target, true);
				}
			}
		}

	}
}
