using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_227 : SimTemplate //* 风险投资公司雇佣兵 Venture Co. Mercenary
	{
		//Your minions cost (3) more.
		//你的随从牌的法力值消耗增加（3）点。
        public override void onAuraStarts(Playfield p, Minion own)
		{
           if(own.own) p.ownMinionsCostMore += 3;
		}

        public override void onAuraEnds(Playfield p, Minion own)
        {
           if(own.own) p.ownMinionsCostMore -= 3;
        }
	}
}