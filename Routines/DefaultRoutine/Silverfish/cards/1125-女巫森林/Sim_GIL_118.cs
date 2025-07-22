using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_118 : SimTemplate //* 癫狂的医生 Deranged Doctor
//<b>Deathrattle:</b> Restore #8 Health to your hero.
//<b>亡语：</b>为你的英雄恢复#8点生命值。 
    {

        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                int heal = p.getMinionHeal(8);
                p.minionGetDamageOrHeal(p.ownHero, -heal, true);
            }
            else
            {
                int heal = p.getEnemyMinionHeal(8);
                p.minionGetDamageOrHeal(p.enemyHero, -heal, true);
            }
        }

    }

}