using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_402 : SimTemplate //* 铸甲师 Armorsmith
	{
		//Whenever a friendly minion_takes damage, gain 1 Armor.
		//每当一个友方随从受到伤害，便获得1点护甲值。
        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.own)
            {
                for (int i = 0; i < anzOwnMinionsGotDmg - anzOwnHeroGotDmg; i++)
                {
					p.minionGetArmor(p.ownHero, 1);
                }
            }
            else
            {
                for (int i = 0; i < anzEnemyMinionsGotDmg - anzEnemyHeroGotDmg; i++)
                {
                    p.minionGetArmor(p.enemyHero, 1);
                }
            }
        }
	}
}