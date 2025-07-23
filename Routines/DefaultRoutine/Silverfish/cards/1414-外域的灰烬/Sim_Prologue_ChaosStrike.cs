using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：2
	//Chaos Strike
	//混乱打击
	//Give your hero +2_Attack this turn. Draw a card.
	//在本回合中，使你的英雄获得+2攻击力。抽一张牌。
	class Sim_Prologue_ChaosStrike : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			var hero = ownplay ? p.ownHero : p.enemyHero;
			p.minionGetTempBuff(hero, 2, 0);
			hero.updateReadyness();
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}
		
	}
}
