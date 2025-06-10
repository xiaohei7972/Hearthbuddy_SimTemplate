using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_026 : SimTemplate //* 假死 Feign Death
//Trigger all <b>Deathrattles</b> on your minions.
//触发所有友方随从的<b>亡语</b>。 
    {

        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.doDeathrattles(new List<Minion>(p.ownMinions));
            }
            else
            {
                p.doDeathrattles(new List<Minion>(p.enemyMinions));
            }
        }


    }

}