using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_350 : SimTemplate //* 先知维伦 Prophet Velen
//Double the damage and healing of your spells and Hero Power.
//使你的法术和英雄技能的伤害和治疗效果翻倍。 
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
            if (m.own)
            {
                p.doublepriest--;
            }
        }

	}
}