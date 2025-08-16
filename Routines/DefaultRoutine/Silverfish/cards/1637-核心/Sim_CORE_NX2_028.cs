using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：3 攻击力：4 生命值：3
	//Hookfist-3000
	//钩拳-3000型
	//After your hero attacks, gain 4 Armor anddraw a card.
	//在你的英雄攻击后，获得4点护甲值并抽一张牌。
	class Sim_CORE_NX2_028 : SimTemplate
	{
		public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
		{
			if (triggerMinion.own == hero.own)
			{
				p.minionGetArmor(hero, 4);
				p.drawACard(CardDB.cardIDEnum.None, triggerMinion.own);
			}
		}

	}
}
