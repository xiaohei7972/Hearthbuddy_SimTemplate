using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_012 : SimTemplate //* 暗影子嗣 Spawn of Shadows
//<b>Inspire:</b> Deal 4 damage to each hero.
//<b>激励：</b>对每个英雄造成4点伤害。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				p.minionGetDamageOrHeal(p.enemyHero, 4);
				p.minionGetDamageOrHeal(p.ownHero, 4);
			}
        }
	}
}