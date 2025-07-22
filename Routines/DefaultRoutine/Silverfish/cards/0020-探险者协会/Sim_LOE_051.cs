using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_051 : SimTemplate //* 丛林枭兽 Jungle Moonkin
//Both players have<b>Spell Damage +2</b>.
//每个玩家获得<b>法术伤害+2</b>。 
	{
		

        public override void onAuraStarts(Playfield p, Minion own)
		{
			p.spellpower+=2;
			p.enemyspellpower+=2;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
			p.spellpower-=2;
			p.enemyspellpower-=2;
        }
	}
}