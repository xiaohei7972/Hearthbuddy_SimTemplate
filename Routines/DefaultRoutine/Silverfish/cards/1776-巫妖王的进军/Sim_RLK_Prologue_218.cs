using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：2 生命值：2
	//Silvermoon Arcanist
	//银月城奥术师
	//[x]<b>Spell Damage +2</b>
	//<b>法术伤害+2</b>
	class Sim_RLK_Prologue_218 : SimTemplate
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
