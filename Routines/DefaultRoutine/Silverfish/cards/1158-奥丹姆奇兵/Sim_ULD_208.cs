using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_208 : SimTemplate //* 卡塔图防御者
	{

		// 嘲讽，复生，亡语：为你的英雄恢复#3点生命值。

		public override void onDeathrattle(Playfield p, Minion m)
		{
			int heal = 3;
			heal = m.own ? p.getMinionHeal(heal) : p.getEnemyMinionHeal(heal);
			var hero = m.own ? p.ownHero : p.enemyHero;
			p.minionGetDamageOrHeal(hero, -heal, true);
		}
	}
}