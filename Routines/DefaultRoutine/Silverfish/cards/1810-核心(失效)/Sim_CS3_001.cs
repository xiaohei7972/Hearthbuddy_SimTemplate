using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：5 攻击力：5 生命值：5
	//Aegwynn, the Guardian
	//守护者艾格文
	//<b>Spell Damage +2</b><b>Deathrattle:</b> The next minion_you draw inherits these powers.
	//<b>法术伤害+2</b>，<b>亡语：</b>你抽到的下一张随从牌会继承这些能力。
	class Sim_CS3_001 : SimTemplate
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
