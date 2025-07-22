using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_068 : SimTemplate //* 莫尔葛熔魔 Mo'arg Forgefiend
	{
		//<b>Taunt</b><b>Deathrattle:</b> Gain 8 Armor.
		//<b>嘲讽</b>，<b>亡语：</b>获得8点护甲值。
		public override void onDeathrattle(Playfield p, Minion m)//亡语
		{
			p.minionGetArmor(m.own ? p.ownHero : p.enemyHero, 8);
		}

	}
}
