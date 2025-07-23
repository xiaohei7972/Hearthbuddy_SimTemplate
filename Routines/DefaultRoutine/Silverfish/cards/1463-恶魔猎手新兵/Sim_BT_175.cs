using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_175 : SimTemplate //* 双刃斩击 Twin Slice
	{
		//Give your hero +2 Attack this turn. Add 'Second Slice' to your hand.
		//在本回合中，使你的英雄获得+2攻击力。将“二次斩击”置入你的手牌。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			var hero = ownplay ? p.ownHero : p.enemyHero;
			p.minionGetTempBuff(hero, 2, 0);
			hero.updateReadyness();
			p.drawACard(CardDB.cardIDEnum.BT_175t, ownplay, true);
			
		}
	}
}
