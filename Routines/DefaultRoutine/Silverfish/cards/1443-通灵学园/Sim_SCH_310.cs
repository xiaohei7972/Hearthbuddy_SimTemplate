using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 研究伙伴 Lab Partner
    //<b>Spell Damage +1</b>
    //<b>法术伤害+1</b>
    class Sim_SCH_310 : SimTemplate
    {
        public override void onAuraStarts(Playfield p, Minion m)
        {
            if (m.own) p.spellpower += m.spellpower;
            else p.enemyspellpower += m.spellpower;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.spellpower -= m.spellpower;
            else p.enemyspellpower -= m.spellpower;
        }

    }
}
