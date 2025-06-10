using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_FP1_001 : SimTemplate //* 肉用僵尸 Zombie Chow
//<b>Deathrattle:</b> Restore #5 Health to the enemy hero.
//<b>亡语：</b>为敌方英雄恢复#5点生命值。 
    {

        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            int heal = (m.own) ? p.getMinionHeal(5) : p.getEnemyMinionHeal(5);

            p.minionGetDamageOrHeal(m.own ? p.enemyHero : p.ownHero, -heal);
        }

    }
}