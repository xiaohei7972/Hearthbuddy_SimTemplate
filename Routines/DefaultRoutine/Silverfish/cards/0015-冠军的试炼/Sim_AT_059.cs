using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_059 : SimTemplate //* 神勇弓箭手 Brave Archer
//<b>Inspire:</b> If your hand is empty, deal 2 damage to the enemy hero.
//<b>激励：</b>如果你没有其他手牌，则对敌方英雄造成2点伤害。 
	{
		
		
		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
	            int cardsCount = (own) ? p.owncards.Count : p.enemyAnzCards;
				if (cardsCount <= 0)
				{
					p.minionGetDamageOrHeal(own ? p.enemyHero : p.ownHero, 2);
				}
			}
        }
	}
}