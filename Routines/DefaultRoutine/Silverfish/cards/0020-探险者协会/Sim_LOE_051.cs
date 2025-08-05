using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 丛林枭兽 Jungle Moonkin
	//Both players have<b>Spell Damage +2</b>.
	//每个玩家获得<b>法术伤害+2</b>。 
	class Sim_LOE_051 : SimTemplate
	{


		public override void onAuraStarts(Playfield p, Minion own)
		{
			p.spellpower += own.spellpower;
			p.enemyspellpower += own.spellpower;
		}

		public override void onAuraEnds(Playfield p, Minion m)
		{
			p.spellpower -= m.spellpower;
			p.enemyspellpower -= m.spellpower;
		}

	}
}