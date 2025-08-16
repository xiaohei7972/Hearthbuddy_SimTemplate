using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 鲨鳍后援
	// 在你的英雄攻击后,召唤一个1/1的海盗.
	class Sim_TRL_507 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_507t);
		public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
		{
			if (triggerMinion.own == hero.own) p.callKid(kid, triggerMinion.zonepos, triggerMinion.own);
		}
	}
}