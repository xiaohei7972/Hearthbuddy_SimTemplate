using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_726 : SimTemplate //斯卡基尔
	{
		//Your minions cost (1).

		public override void onAuraStarts(Playfield p, Minion m)
		{
            if (m.own) p.anzOwnScargil++;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.anzOwnScargil--;
        }
	}
}