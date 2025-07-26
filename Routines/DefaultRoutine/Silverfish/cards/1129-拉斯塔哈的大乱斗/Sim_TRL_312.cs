using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：3
	//Spellzerker
	//狂暴咒术师
	//Has <b>Spell Damage +2</b> while damaged.
	//受伤时拥有<b>法术伤害+2</b>。
	class Sim_TRL_312 : SimTemplate
	{
		public override void onEnrageStart(Playfield p, Minion m)
		{
			m.spellpower += 2;
			m.updateReadyness();
		}

		public override void onEnrageStop(Playfield p, Minion m)
		{
			m.spellpower -= 2;
			m.updateReadyness();
		}

	}
}
