using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：2 攻击力：2 生命值：3
	//Eye of Shadow
	//暗影之眼
	//Your hero has <b>Lifesteal</b>.
	//你的英雄拥有<b>吸血</b>。
	class Sim_ETC_398 : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion m)
		{
			if (m.own)
			{
				p.ownHero.lifesteal = true;
			}
			else
			{
				p.enemyHero.lifesteal = true;
			}

		}

		public override void onAuraEnds(Playfield p, Minion m)
		{
			if (m.own)
			{
				p.ownHero.lifesteal = false;
			}
			else
			{
				p.enemyHero.lifesteal = false;
			}
		}
	}
}
