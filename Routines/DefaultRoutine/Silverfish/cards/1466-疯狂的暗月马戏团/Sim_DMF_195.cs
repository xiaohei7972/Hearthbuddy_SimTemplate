using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_195 : SimTemplate //* 零食大冲关 Snack Run
	{
		//<b>Discover</b> a spell. Restore Health to your hero equal to its Cost.
		//<b>发现</b>一张法术牌。为你的英雄恢复等同于其法力值消耗的生命值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.thecoin, ownplay, true);
			int heal = (ownplay) ? p.getMinionHeal(3) : p.getEnemyMinionHeal(3);
			p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -heal);
		}

	}
}
