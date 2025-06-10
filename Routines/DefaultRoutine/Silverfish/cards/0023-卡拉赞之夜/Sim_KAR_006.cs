using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_006 : SimTemplate //* 神秘女猎手 Cloaked Huntress
//Your <b>Secrets</b> cost (0).
//你的<b>奥秘</b>法力值消耗为（0）点。 
	{
		

		public override void onAuraStarts(Playfield p, Minion m)
		{
            if (m.own) p.anzOwnCloakedHuntress++;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.anzOwnCloakedHuntress--;
        }
	}
}