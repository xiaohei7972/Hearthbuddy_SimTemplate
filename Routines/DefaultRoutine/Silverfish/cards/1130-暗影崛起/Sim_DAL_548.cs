using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_548 : SimTemplate //* 艾泽里特元素 Azerite Elemental
//At the start of your turn, gain <b>Spell Damage +2</b>.
//在你的回合开始时，获得<b>法术伤害+2</b>。 
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

	}
}