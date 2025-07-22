using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_026 : SimTemplate //* 幽灵狼前锋 Spirit Alpha
	{
		//[x]After you play a card with<b>Overload</b>, summon a 2/3Spirit Wolf with <b>Taunt</b>.
		//在你使用一张<b>过载</b>牌后，召唤一只2/3并具有<b>嘲讽</b>的幽灵狼。
		public CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_tk11);
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (wasOwnCard == triggerEffectMinion.own && hc.card.overload > 0)
			{
				p.callKid(card, triggerEffectMinion.zonepos, wasOwnCard);
			}
        }	
	}
}
