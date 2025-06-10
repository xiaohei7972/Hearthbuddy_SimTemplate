using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_094 : SimTemplate //* 厚重板甲 Heavy Plate
	{
		//<b>Tradeable</b>Gain 8 Armor.
		//<b>可交易</b>获得8点护甲值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				p.minionGetArmor(p.ownHero, 8);
			}
			else
			{
				p.minionGetArmor(p.enemyHero, 8);
			}
		}

	}
}
