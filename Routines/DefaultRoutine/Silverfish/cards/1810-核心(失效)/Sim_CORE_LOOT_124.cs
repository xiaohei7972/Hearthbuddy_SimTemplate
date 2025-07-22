using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_CORE_LOOT_124 : SimTemplate
    {
        
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)//Õ½ºð
        {

            int pos = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (pos == 1)
            {
                own.taunt = true;
                own.divineshild = true;
            }
        }

    }
}