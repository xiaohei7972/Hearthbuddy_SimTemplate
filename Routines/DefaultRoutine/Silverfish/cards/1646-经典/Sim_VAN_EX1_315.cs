using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_315 : SimTemplate //* 召唤传送门 Summoning Portal
	{
		//Your minions cost (2) less, but not less than (1).
		//你的随从牌的法力值消耗减少（2）点，但不能少于（1）点。
        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own) p.beschwoerungsportal++;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.beschwoerungsportal--;
        }


	}
}