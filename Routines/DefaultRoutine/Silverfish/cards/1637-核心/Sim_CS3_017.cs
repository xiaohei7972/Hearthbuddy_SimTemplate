using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS3_017 : SimTemplate //* 甘尔葛战刃铸造师 Gan'arg Glaivesmith
	{
		//<b>Outcast:</b> Give your hero +3_Attack this turn.
		//<b>流放：</b>在本回合中，使你的英雄获得+3攻击力。
		public override void onCardPlay(Playfield p, Minion own, bool ownplay, Minion target, int choice, bool outcast)
		{
			if (outcast)
			{
				var hero = own.own ? p.ownHero : p.enemyHero;
				p.minionGetTempBuff(hero, 1, 0);
				hero.updateReadyness();
				p.evaluatePenality -= 1;
			}
			else p.evaluatePenality += 3;
		}
	}
}
