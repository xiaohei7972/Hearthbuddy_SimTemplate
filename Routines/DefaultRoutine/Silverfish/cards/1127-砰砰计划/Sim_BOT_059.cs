using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_059 : SimTemplate //* 恒金巡游者 Eternium Rover
//Whenever this minion takes damage, gain 2_Armor.
//每当该随从受到伤害，便获得2点护甲值。 
	{
    

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                for (int i = 0; i < tmp; i++)
                {
					p.minionGetArmor(m.own ? p.ownHero : p.enemyHero, 2);
                }
            }
        }
	}
}