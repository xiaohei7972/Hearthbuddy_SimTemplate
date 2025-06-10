using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_667 : SimTemplate //* 腐烂的苹果树 Rotten Applebaum
//<b>Taunt</b><b>Deathrattle:</b> Restore #4 Health to your hero.
//<b>嘲讽，亡语：</b>为你的英雄恢复#4点生命值。 
    {

        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                int heal = p.getMinionHeal(5);
                p.minionGetDamageOrHeal(p.ownHero, -heal, true);
            }
            else
            {
                int heal = p.getEnemyMinionHeal(5);
                p.minionGetDamageOrHeal(p.enemyHero, -heal, true);
            }
        }

    }

}