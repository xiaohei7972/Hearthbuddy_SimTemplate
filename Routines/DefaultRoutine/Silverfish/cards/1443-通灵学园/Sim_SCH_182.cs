using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_182 : SimTemplate //* 演讲者吉德拉 Speaker Gidra
	{
		//[x]<b><b>Rush</b>, Windfury</b><b><b>Spellburst</b>:</b> Gain Attackand Health equal tothe spell's Cost.
		//<b>突袭，风怒</b><b>法术迸发：</b>获得等同于法术法力值消耗的攻击力和生命值。
		
		public override void OnSpellburst(Playfield p, Minion m, Handmanager.Handcard hc)
		{
			if (hc.manacost == 0) p.evaluatePenality += 10;
			p.minionGetBuffed(m, hc.manacost, hc.manacost);
		}
	}
}
