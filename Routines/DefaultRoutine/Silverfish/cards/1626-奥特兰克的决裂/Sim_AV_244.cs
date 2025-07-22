using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_244 : SimTemplate //* 觅血者 bloodseeker
	{
		//<b>荣誉消灭：</b>获得+1/+1。
		public override void onHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
		{
			if (hero.own && hero.Angr == target.Hp) 
			{
				p.ownWeapon.Angr++;
				p.ownWeapon.Durability++;
				p.minionGetBuffed(p.ownHero, 1, 0);

			}
		}

	}
}
