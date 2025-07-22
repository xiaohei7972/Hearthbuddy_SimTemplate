using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_604 : SimTemplate //* 暴乱狂战士 Frothing Berserker
	{
		//Whenever a minion takes damage, gain +1 Attack.
		//每当一个随从受到伤害，便获得+1攻击力。

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            p.minionGetBuffed(m, anzOwnMinionsGotDmg + anzEnemyMinionsGotDmg - anzOwnHeroGotDmg - anzEnemyHeroGotDmg, 0);
        }

	}
}