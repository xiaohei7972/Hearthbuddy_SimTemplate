using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_006 : SimTemplate //* 机械跃迁者 Mechwarper
//Your Mechs cost (1) less.
//你的机械的法力值消耗减少（1）点。 
    {

        

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnMechwarper++;
            }
            else
            {
                p.anzEnemyMechwarper++;

            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnMechwarper--;
            }
            else
            {
                p.anzEnemyMechwarper--;
            }
        }


    }

}