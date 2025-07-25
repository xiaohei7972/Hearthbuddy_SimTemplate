using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 甘尔葛战刃铸造师 Gan'arg Glaivesmith
	// //<b>Outcast:</b> Give your hero +3_Attack this turn.
	//<b>流放：</b>在本回合中，使你的英雄获得+3攻击力。
	class Sim_CS3_017 : SimTemplate
	{
		
		public override void onCardPlay(Playfield p, Minion own, bool ownplay, Minion target, int choice, bool outcast)
		{
			if (outcast)
			{
				Minion hero = own.own ? p.ownHero : p.enemyHero;
				p.minionGetTempBuff(hero, 3, 0);
				hero.updateReadyness();
				p.evaluatePenality -= 1;
			}
			else p.evaluatePenality += 3;
		}
	}
}
