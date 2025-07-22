using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：3 攻击力：3 生命值：3
	//Velarok Windblade
	//威拉罗克·温布雷
	//[x]While this is in your hand,play a card from anotherclass to reveal Velarok'strue form!
	//当本牌在你手牌中时，使用一张另一职业的卡牌以揭示威拉罗克的真正形态！
	class Sim_WW_364 : SimTemplate
	{
		// 将要变成的卡
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_364t);
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
		{
			int hero = p.ownHero.handcard.card.Class;
			// 判断打出牌不是中立牌还有牌的职业不是当前职业的牌
			if (!(hc.card.Class == 12) && hc.card.Class != hero)
			{
				triggerhc.card = card;
			};
		}

	}
}
