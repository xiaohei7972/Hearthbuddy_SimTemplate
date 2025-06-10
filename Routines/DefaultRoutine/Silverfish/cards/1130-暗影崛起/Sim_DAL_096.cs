using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_096 : SimTemplate //* 紫罗兰典狱官 Violet Warden
//<b>Taunt</b><b>Spell Damage +1</b>
//<b>嘲讽</b><b>法术伤害+1</b> 
	{


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