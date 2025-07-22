using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_049 : SimTemplate //* 加兹瑞拉 Gahz'rilla
//Whenever this minion takes damage, double its Attack.
//每当该随从受到伤害，便使其攻击力翻倍。 
    {
        

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                p.minionGetBuffed(m, m.Angr * (2 ^ tmp) - m.Angr, 0);
            }
        }
    }
}