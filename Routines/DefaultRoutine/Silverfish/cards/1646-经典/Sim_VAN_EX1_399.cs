using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_399 : SimTemplate //* 古拉巴什狂暴者 Gurubashi Berserker
	{
		//Whenever this minion takes damage, gain +3_Attack.
		//每当该随从受到伤害，便获得+3攻击力。

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                for (int i = 0; i < tmp; i++)
                {
					p.minionGetBuffed(m, 3, 0);
                }
            }
        }
	}
}