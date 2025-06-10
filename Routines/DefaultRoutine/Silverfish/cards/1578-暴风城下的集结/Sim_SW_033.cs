using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_033 : SimTemplate //* 运河慢步者 Canal Slogge
	{
		//<b>Rush</b>,<b>Lifesteal</b>, <b>Overload: (1)</b>
		//<b>突袭</b>，<b>吸血</b>,<b>过载：（1）</b>
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.ueberladung++;
		}

	}
}