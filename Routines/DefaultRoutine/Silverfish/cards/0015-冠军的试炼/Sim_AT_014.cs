using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_014 : SimTemplate //* 暗影魔 Shadowfiend
//Whenever you draw a card, reduce its Cost by (1).
//每当你抽一张牌时，使其法力值消耗减少（1）点。 
	{
		

        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own) p.anzOwnShadowfiend++;
		}

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own) p.anzOwnShadowfiend--;
        }
	}
}