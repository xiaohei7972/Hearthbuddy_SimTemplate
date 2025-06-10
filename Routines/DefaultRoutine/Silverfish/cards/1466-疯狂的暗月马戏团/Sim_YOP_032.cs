using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_032 : SimTemplate //* 护甲商贩 Armor Vendor
	{
		//<b>Battlecry:</b> Give 4 Armor to_each hero.
		//<b>战吼：</b>使每个英雄获得4点护甲值。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.minionGetArmor(p.ownHero, 4);
			p.minionGetArmor(p.enemyHero, 4);
		}
	}
}
