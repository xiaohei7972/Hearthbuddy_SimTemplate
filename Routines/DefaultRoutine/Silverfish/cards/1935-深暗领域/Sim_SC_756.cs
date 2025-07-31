using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：12 攻击力：2 生命值：14
	//Carrier
	//航母
	//[x]At the end of your turn,summon four 4/1Interceptors that attackrandom enemies.
	//在你的回合结束时，召唤四架4/1的拦截机并使其攻击随机敌人。
	class Sim_SC_756 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_756t);
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			if (triggerEffectMinion.own == turnEndOfOwner)
			{
				p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);
				p.callKid(kid, triggerEffectMinion.zonepos + 1, triggerEffectMinion.own);
				p.callKid(kid, triggerEffectMinion.zonepos - 1, triggerEffectMinion.own);
				p.callKid(kid, triggerEffectMinion.zonepos - 2, triggerEffectMinion.own);
				// 让召唤物攻击有点麻烦,以后改callKid了再写
			}
		}

	}
}
