using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_310 : SimTemplate //* 研究伙伴 Lab Partner
	{
        //<b>Spell Damage +1</b>
        //<b>法术伤害+1</b>
        public override void onAuraStarts(Playfield p, Minion m)
        {
            if (m.own) p.spellpower++;
            else p.enemyspellpower++;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.spellpower--;
            else p.enemyspellpower--;
        }

    }
}
