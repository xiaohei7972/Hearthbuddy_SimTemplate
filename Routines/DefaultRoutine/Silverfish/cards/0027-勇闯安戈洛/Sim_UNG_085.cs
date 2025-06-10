using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_085 : SimTemplate //* 翡翠蜂后 Emerald Hive Queen
//Your minions cost (2) more.
//你的随从的法力值消耗增加（2）点。 
	{
		

        public override void onAuraStarts(Playfield p, Minion own)
		{
           if(own.own) p.ownMinionsCostMore += 2;
		}

        public override void onAuraEnds(Playfield p, Minion own)
        {
           if(own.own) p.ownMinionsCostMore -= 2;
        }
	}
}