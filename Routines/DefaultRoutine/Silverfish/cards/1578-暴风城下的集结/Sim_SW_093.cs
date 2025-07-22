using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_093 : SimTemplate //* 暴风城海盗 Stormwind Freebooter
	{
		//<b>Battlecry:</b> Give your hero +2 Attack this turn.
		//<b>战吼：</b>在本回合中，使你的英雄获得+2攻击力。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			var hero = m.own ? p.ownHero : p.enemyHero;
			p.minionGetTempBuff(hero, 2, 0);
			hero.updateReadyness();
		}
	}
}
