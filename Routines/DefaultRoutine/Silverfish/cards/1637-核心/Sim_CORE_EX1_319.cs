using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_CORE_EX1_319 : SimTemplate //flameimp
    {

        //    kampfschrei:/ fÃ¼gt eurem helden 3 schaden zu.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 3);
        }


    }
}