using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_307t : SimTemplate //* 灵魂残片 Soul Fragment
	{
		//<b>Casts When Drawn</b>Restore #2 Health to your hero.
		//<b>抽到时施放</b>为你的英雄恢复#2点生命值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int heal = (ownplay) ? p.getSpellHeal(2) : p.getEnemySpellHeal(2);
			Minion m = ownplay ? p.ownHero : p.enemyHero;
			p.minionGetDamageOrHeal(m, -heal);
		}
	}
}
