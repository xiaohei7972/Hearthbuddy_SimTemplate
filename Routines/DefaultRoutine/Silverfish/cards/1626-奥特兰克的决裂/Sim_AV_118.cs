using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 历战先锋 battlewornvanguard
	//在你的英雄攻击后，召唤两只1/1的 邪翼蝠。
	class Sim_AV_118 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_922t);
		public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
		{
			if (triggerMinion.own == hero.own)
			{
				p.callKid(kid, triggerMinion.zonepos, triggerMinion.own);
				p.callKid(kid, triggerMinion.zonepos - 1, triggerMinion.own);
			}
			
		}
	}
}
