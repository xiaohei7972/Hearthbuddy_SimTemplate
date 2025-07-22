using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_685 : SimTemplate //* 圣光楷模 Paragon of Light
//While this minion has 3 or more Attack, it has <b>Taunt</b> and <b>Lifesteal</b>.
//如果该随从的攻击力大于或等于3，便具有<b>嘲讽</b>和<b>吸血</b>。 
	{
		

		public override void onAuraStarts(Playfield p, Minion m)
		{
            for (int i = m.Angr - 1; i >= 3; i--)
            {
                m.taunt = true;
				p.anzOwnTaunt++;
            }
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            for (int i = m.Angr - 1; i >= 3; i--)
            {
                m.taunt = true;
				p.anzOwnTaunt++;
            }
        }
	}
}