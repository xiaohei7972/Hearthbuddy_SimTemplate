using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 法力怨魂 Mana Wraith
	//ALL minions cost (1) more.
	//召唤所有随从的法力值消耗增加（1）点。
	class Sim_EX1_616 : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion own)
		{
			p.managespenst++;
		}

		public override void onAuraEnds(Playfield p, Minion m)
		{
			p.managespenst--;
		}

	}
}