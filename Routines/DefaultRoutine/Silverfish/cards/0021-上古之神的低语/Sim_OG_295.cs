using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_295 : SimTemplate //* 异教药剂师 Cult Apothecary
//<b>Battlecry:</b> For each enemy minion, restore #2 Health to your hero.
//<b>战吼：</b>每有一个敌方随从，便为你的英雄恢复#2点生命值。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if (own.own) p.minionGetDamageOrHeal(p.ownHero, -p.getMinionHeal(2 * p.enemyMinions.Count));
			else p.minionGetDamageOrHeal(p.enemyHero, -p.getEnemyMinionHeal(2 * p.ownMinions.Count));
        }
    }
}