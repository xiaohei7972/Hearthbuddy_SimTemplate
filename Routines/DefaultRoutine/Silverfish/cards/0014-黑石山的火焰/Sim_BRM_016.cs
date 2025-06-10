using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_016 : SimTemplate //* 掷斧者 Axe Flinger
//Whenever this minion takes damage, deal 2 damage to the enemy hero.
//每当该随从受到伤害，对敌方英雄造成2点伤害。 
	{
		

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                for (int i = 0; i < tmp; i++)
                {
					p.minionGetDamageOrHeal(m.own ? p.enemyHero : p.ownHero, 2);
                }
            }
        }
	}
}