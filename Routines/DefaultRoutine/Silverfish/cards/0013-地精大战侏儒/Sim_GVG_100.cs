using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_100 : SimTemplate //* 漂浮观察者 Floating Watcher
//Whenever your hero takes damage on your turn, gain +2/+2.
//每当你的英雄在你的回合受到伤害，便获得+2/+2。 
    {
        

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (p.ownHero.anzGotDmg > 0 && m.own)
            {
                p.minionGetBuffed(m, 2 * p.ownHero.anzGotDmg, 2 * p.ownHero.anzGotDmg);
            }
            else if (p.enemyHero.anzGotDmg > 0 && !m.own)
            {
                p.minionGetBuffed(m, 2 * p.enemyHero.anzGotDmg, 2 * p.enemyHero.anzGotDmg);
            }
        }
    }
}