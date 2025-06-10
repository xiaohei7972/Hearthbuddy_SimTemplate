using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_FP1_006 : SimTemplate //* 死亡战马 Deathcharger
//<b>Charge. Deathrattle:</b> Deal 3 damage to your hero.
//<b>冲锋，亡语：</b>对你的英雄造成3点伤害。 
    {

        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.minionGetDamageOrHeal(m.own ? p.ownHero : p.enemyHero, 3);
        }

    }
}