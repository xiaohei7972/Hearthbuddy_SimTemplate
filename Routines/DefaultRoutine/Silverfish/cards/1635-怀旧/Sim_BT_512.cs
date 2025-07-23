using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 心中的恶魔 Inner Demon
	// //Give your hero +8_Attack this turn.
	//在本回合中，使你的英雄获得+8攻击力。
	class Sim_BT_512 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			p.minionGetTempBuff(hero, 8, 0);
			hero.updateReadyness();
			
		}

	}
}
