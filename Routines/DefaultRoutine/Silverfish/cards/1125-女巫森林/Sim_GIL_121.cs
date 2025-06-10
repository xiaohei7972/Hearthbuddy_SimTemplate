using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_121 : SimTemplate //* 黑沼枭兽 Darkmire Moonkin
//<b>Spell Damage +2</b>
//<b>法术伤害+2</b> 
	{


        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own)
            {
                p.spellpower+=2;
            }
            else
            {
                p.enemyspellpower+=2;
            }
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.spellpower -= 2;
            }
            else
            {
                p.enemyspellpower -= 2;
            }
        }

	}
}