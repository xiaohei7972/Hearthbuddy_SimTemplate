using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：4 攻击力：3 生命值：4
	//Theldurin the Lost
	//迷失者塞尔杜林
	//[x]<b>Battlecry:</b> If your deckstarted with no duplicates,gain <b>Immune</b> this turn andattack all enemies.
	//<b>战吼：</b>如果你的套牌里没有相同的牌，在本回合中获得<b>免疫</b>并攻击所有敌人。
	class Sim_WW_815 : SimTemplate
	{

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.prozis.noDuplicates)
			{
				List<Minion> minions = own.own ? p.enemyMinions : p.ownMinions;
				if (own.own)
				{
					minions.Add(p.enemyHero);
				}
				else
				{
					minions.Add(p.ownHero);
				}
				own.immune = true;
				foreach (Minion minion in minions)
				{
					p.minionAttacksMinion(own, minion);
				}
			}
		}

	}
}
