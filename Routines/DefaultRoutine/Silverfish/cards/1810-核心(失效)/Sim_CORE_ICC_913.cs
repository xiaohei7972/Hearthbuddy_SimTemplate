using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：1 生命值：1
	//Tainted Zealot
	//被污染的狂热者
	//<b>Divine Shield</b><b>Spell Damage +1</b>
	//<b>圣盾</b><b>法术伤害+1</b>
	class Sim_CORE_ICC_913 : SimTemplate
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
