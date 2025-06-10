using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_039 : SimTemplate //* 死灵机械师 Necromechanic
//Your <b>Deathrattles</b> trigger twice.
//你的<b>亡语</b>会触发两次。 
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