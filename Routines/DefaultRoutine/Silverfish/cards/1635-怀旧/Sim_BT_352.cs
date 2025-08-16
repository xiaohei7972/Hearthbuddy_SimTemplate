using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 萨特监工
	// 在你的英雄攻击后,召唤一个2/2的海盗.
	class Sim_BT_352 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_352t);
		public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
		{
			if (triggerMinion.own == hero.own)
			{
				p.callKid(kid, triggerMinion.zonepos, triggerMinion.own);
			}

		}

	}
}