using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_033 : SimTemplate //* 赛车回火 Backfire
	{
		//Draw 3 cards. Deal $3 damage to your hero.
		//抽三张牌。对你的英雄造成$3点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, 3);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}
	}
}
