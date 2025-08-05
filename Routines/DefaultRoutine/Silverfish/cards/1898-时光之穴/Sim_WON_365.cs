using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：0 生命值：7
	//Street Trickster
	//杂耍小鬼
	//<b>Spell Damage +2</b>
	//<b>法术伤害+2</b>
	class Sim_WON_365 : SimTemplate
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
