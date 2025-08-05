using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：9 攻击力：4 生命值：12
	//Malygos
	//玛里苟斯
	//<b>Spell Damage +5</b>
	//<b>法术伤害+5</b>
	class Sim_CORE_VAN_EX1_563 : SimTemplate
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
