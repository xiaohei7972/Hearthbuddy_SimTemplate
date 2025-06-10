using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_309 : SimTemplate //* 绝望祷言 Desperate Prayer
	{
		//Restore #5 Health to each hero.
		//为双方英雄恢复#5点生命值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetDamageOrHeal(p.ownHero, -5);
            p.minionGetDamageOrHeal(p.enemyHero, -5);
		}			
		
	}
}
