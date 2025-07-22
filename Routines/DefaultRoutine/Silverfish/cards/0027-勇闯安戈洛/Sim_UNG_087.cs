using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_087 : SimTemplate //* 苦潮多头蛇 Bittertide Hydra
//Whenever this minion takes damage, deal 3 damage to_your hero.
//每当该随从受到伤害，对你的英雄造成3点伤害。 
	{
		

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                m.anzGotDmg = 0;
				p.minionGetDamageOrHeal(m.own ? p.ownHero : p.enemyHero, 3);
            }
        }
	}
}