using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：3 攻击力：4 生命值：1
	//Jellyfish
	//水母
	//<b>Spell Damage +2</b>
	//<b>法术伤害+2</b>
	class Sim_TID_708t : SimTemplate
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
