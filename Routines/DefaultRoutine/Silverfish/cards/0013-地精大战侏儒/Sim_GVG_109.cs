using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_109 : SimTemplate //* 小个子法师 Mini-Mage
    {
		//<b>Stealth</b><b>Spell Damage +1</b>
		//<b>潜行，法术伤害+1</b>

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.spellpower++;
            }
            else
            {
                p.enemyspellpower++;
            }
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {

            if (m.own)
            {
                p.spellpower--;
            }
            else
            {
                p.enemyspellpower--;
            }
        }
        


    }

}
