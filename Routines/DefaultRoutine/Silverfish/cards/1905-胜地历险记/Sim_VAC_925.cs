using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：2
	//Sigil of Skydiving
	//伞降咒符
	//At the start of yournext turn, summon three 1/1 Pirates with <b>Charge</b>.
	//在你的下个回合开始时，召唤三个1/1并具有<b>冲锋</b>的海盗。
	class Sim_VAC_925 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_926t);
		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
		{
			if (turnStartOfOwner)
			{
				p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);
				p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);
				p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);
			}
		}
	}
}
