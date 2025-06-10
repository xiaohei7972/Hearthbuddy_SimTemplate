using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_076 : SimTemplate //* 小个子召唤师 Pint-Sized Summoner
	{
		//The first minion you play each turn costs (1) less.
		//你每个回合使用的第一张随从牌的法力值消耗减少（1）点。
        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own) p.winzigebeschwoererin++;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.winzigebeschwoererin--;
        }

	}
}