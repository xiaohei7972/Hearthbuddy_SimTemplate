using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_039 : SimTemplate //* 杂耍小鬼 Street Trickster
//<b>Spell Damage +1</b>
//<b>法术伤害+1</b> 
	{
		

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