using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_026 : SimTemplate //* 愤怒卫士 Wrathguard
//Whenever this minion takes damage, also deal that amount to your hero.
//每当该随从受到伤害，对你的英雄造成等量的伤害。 
	{
		

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                m.anzGotDmg = 0;
				p.minionGetDamageOrHeal(m.own ? p.ownHero : p.enemyHero, m.GotDmgValue);
            }
        }
	}
}