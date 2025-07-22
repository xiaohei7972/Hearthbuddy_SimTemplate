using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_056 : SimTemplate //* 香料面包师 Spice Bread Baker
	{
		//<b>Battlecry:</b> Restore Health to your hero equal to your hand size.
		//<b>战吼：</b>为你的英雄恢复等同于你手牌数量的生命值。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int x = p.owncards.Count;
			int heal = (own.own) ? p.getMinionHeal(x) : p.getEnemyMinionHeal(x);

			p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -heal);
		}
	}
}
