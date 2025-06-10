using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_040 : SimTemplate //* 荆棘帮箭猪 Hench-Clan Shadequill
//<b>Deathrattle:</b> Restore 5 Health to the enemy hero.
//<b>亡语：</b>为敌方英雄恢复5点生命值。 
    {

        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            int heal = (m.own) ? p.getMinionHeal(5) : p.getEnemyMinionHeal(5);

            p.minionGetDamageOrHeal(m.own ? p.enemyHero : p.ownHero, -heal);
        }

    }
}