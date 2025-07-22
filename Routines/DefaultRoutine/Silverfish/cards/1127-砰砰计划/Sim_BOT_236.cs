using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_236 : SimTemplate //* 水晶工匠坎格尔 Crystalsmith Kangor
//<b>Divine Shield</b>, <b>Lifesteal</b>Your healing is doubled.
//<b>圣盾，吸血</b>你的治疗效果翻倍。 
	{


		public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own)
            {
                p.doublepriest++;
            }
		}
        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.doublepriest--;
        }
	}
}