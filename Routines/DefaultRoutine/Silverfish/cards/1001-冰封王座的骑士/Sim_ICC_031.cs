using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_031: SimTemplate //* 暗夜嗥狼 Night Howler
//Whenever this minion takesdamage, gain +2 Attack.
//每当该随从受到伤害，便获得+2攻击力。 
    {
        

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                for (int i = 0; i < tmp; i++)
                {
                    p.minionGetBuffed(m, 2, 0);
                }
            }
        }
    }
}