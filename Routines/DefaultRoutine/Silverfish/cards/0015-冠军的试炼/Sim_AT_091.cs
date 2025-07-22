using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_091 : SimTemplate //* 赛场医师 Tournament Medic
//<b>Inspire:</b> Restore #2 Health to your hero.
//<b>激励：</b>为你的英雄恢复#2点生命值。 
	{
		
		
		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				int heal = (own) ? p.getMinionHeal(2) : p.getEnemyMinionHeal(2);
				p.minionGetDamageOrHeal(own ? p.ownHero : p.enemyHero, -heal);
			}
        }
	}
}