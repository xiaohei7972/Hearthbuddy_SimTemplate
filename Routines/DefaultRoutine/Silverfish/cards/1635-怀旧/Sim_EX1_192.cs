using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_192 : SimTemplate //* 圣光闪耀 Radiance
	{
		//Restore #5 Health to your hero.
		//为你的英雄恢复#5点生命值。
	        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int heal = (ownplay) ? p.getSpellHeal(5) : p.getEnemySpellHeal(5);

            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -heal);
        }	
		
	}
}
