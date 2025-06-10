using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_066 : SimTemplate //* 小刀商贩 Knife Vendor
	{
		//<b>Battlecry:</b> Deal 4 damage to each hero.
		//<b>战吼：</b>对每个英雄造成4点伤害。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
				p.minionGetDamageOrHeal(p.enemyHero, 4);
				p.minionGetDamageOrHeal(p.ownHero, 4);
        }
		
		
	}
}
