using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_646 : SimTemplate //* 发条机器人 Clockwork Automaton
//Double the damage and_healing of your Hero_Power.
//使你的英雄技能的伤害和治疗效果翻倍。 
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