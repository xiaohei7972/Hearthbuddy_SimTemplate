using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：3
	//Rainbow Glowscale
	//虹彩闪鳞纳迦
	//<b>Spell Damage +1</b>
	//<b>法术伤害+1</b>
	class Sim_TSC_053 : SimTemplate
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
