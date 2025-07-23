using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：4
	//Going Down Swinging
	//低沉摇摆
	//[x]Give your hero +2 Attackand <b>Immune</b> this turn, then attack each enemy minion.
	//在本回合中，使你的英雄获得+2攻击力和<b>免疫</b>，然后攻击每个敌方随从。
	class Sim_ETC_413 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			List<Minion> minions = ownplay ? p.enemyMinions : p.ownMinions;
			p.minionGetTempBuff(hero, 2, 0);
			hero.immune = true;
            hero.updateReadyness();
			
			foreach (Minion minion in minions)
			{
				p.minionAttacksMinion(hero, minion);
			}

		}

	}
}
