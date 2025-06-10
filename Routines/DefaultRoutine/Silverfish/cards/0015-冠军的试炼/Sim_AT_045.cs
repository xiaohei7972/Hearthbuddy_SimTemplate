using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_045 : SimTemplate //* 艾维娜 Aviana
//Your minions cost (1).
//你的随从牌的法力值消耗为（1）点。 
	{
		

		public override void onAuraStarts(Playfield p, Minion m)
		{
            if (m.own) p.anzOwnAviana++;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.anzOwnAviana--;
        }
	}
}