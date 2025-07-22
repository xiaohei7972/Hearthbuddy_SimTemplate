using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_HERO_01fbp2 : SimTemplate //* 铜墙铁壁！ Tank Up!
	{
		//<b>Hero Power</b>Gain 4 Armor.
		//<b>英雄技能</b>获得4点护甲值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				p.minionGetArmor(p.ownHero, 4);
			}
			else
			{
				p.minionGetArmor(p.enemyHero, 4);
			}
		}

	}
}
