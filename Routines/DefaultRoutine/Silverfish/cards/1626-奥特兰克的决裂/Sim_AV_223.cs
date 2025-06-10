using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_223 : SimTemplate //* 范达尔雷矛 vanndarstormpike
	{
		//<b>战吼：</b>如果该随从的法力值消耗小于你牌库中的所有随从牌，则使这些牌的法力值消耗减少（3）点。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            bool tag = true;
            CardDB.cardIDEnum deckCard = new CardDB.cardIDEnum();
            CardDB.Card deckMinion = null;
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                deckCard = kvp.Key;
                deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
                if (own.handcard.card.cost >= deckMinion.cost)
                {
                    tag = false;
                    break;
                }
            }

            if (tag)
            {
                foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
                {
                    // ID 转卡
                    deckCard = kvp.Key;
                    deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
                    deckMinion.cost -= 3;
                }
            }
        }
		
	}
}
