using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX6_02H : SimTemplate //* 死灵光环 Necrotic Aura
//<b>Hero Power</b>Deal 3 damage to the enemy hero.
//<b>英雄技能</b>对敌方英雄造成3点伤害。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(3) : p.getEnemyHeroPowerDamage(3);
            p.minionGetDamageOrHeal(ownplay ? p.enemyHero : p.ownHero, dmg);
		}
	}
}