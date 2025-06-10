using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_031 : SimTemplate //* 瑞文戴尔男爵 Baron Rivendare
//Your minions trigger their <b>Deathrattles</b> twice.
//你的随从的<b>亡语</b>将触发两次。 
	{


        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own) p.ownBaronRivendare++;
            else p.enemyBaronRivendare++;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.ownBaronRivendare--;
            }
            else
            {
                p.enemyBaronRivendare--;
            }
        }

	}
}