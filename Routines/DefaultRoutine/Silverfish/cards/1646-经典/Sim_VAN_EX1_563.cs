using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_563 : SimTemplate //* 玛里苟斯 Malygos
	{
		//<b>Spell Damage +5</b>
		//<b>法术伤害+5</b>
        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own)
            {
                p.spellpower+=5;
            }
            else
            {
                p.enemyspellpower+=5;
            }
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.spellpower -= 5;
            }
            else
            {
                p.enemyspellpower -= 5;
            }
        }

	}
}