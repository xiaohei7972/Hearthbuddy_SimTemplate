using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_716 : SimTemplate //* 噬骨先锋 Bonechewer Vanguard
	{
		//[x]<b>Taunt</b>Whenever this minion takesdamage, gain +2 Attack.
		//<b>嘲讽</b>每当该随从受到伤害，便获得+2攻击力。
		public override void onEnrageStart(Playfield p, Minion m)
		{
			m.Angr += 2;
		}

	}
}
