using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_211b : SimTemplate //* 水之祈咒 Invocation of Water
//Restore 12 Health to your hero.
//为你的英雄恢复12点生命值。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = (ownplay) ? p.getSpellHeal(12) : p.getEnemySpellHeal(12);
			p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -heal);
		}
	}
}