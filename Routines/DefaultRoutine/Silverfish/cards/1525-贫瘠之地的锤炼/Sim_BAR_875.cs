using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_875 : SimTemplate //* 逝者之剑 Sword of the Fallen
	{
		//[x]After your hero attacks,cast a <b>Secret</b> fromyour deck.
		//在你的英雄攻击后，从你的牌库中施放一个<b>奥秘</b>。
        CardDB.Card blaine = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_506);
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_875);
		public override void onHeroattack(Playfield p, Minion own, Minion target)//英雄攻击
        {
			bool flag = false;
			// 遍历卡组
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckSecret = CardDB.Instance.getCardDataFromID(deckCard);
				if(deckSecret.Secret)
                {
                    if (p.ownSecretsIDList.Contains(deckCard))
                    {
						flag = true;
                    }
                    else
                    {
						p.ownSecretsIDList.Add(deckCard);
						p.evaluatePenality -= 20;
						return;
					}
				}
			}
            if (flag)
            {
				p.evaluatePenality += 5;
			}
			return;
        }

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(card, ownplay);
		}
	}
}