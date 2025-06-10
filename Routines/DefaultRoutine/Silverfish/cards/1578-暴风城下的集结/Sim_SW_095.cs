using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_095 : SimTemplate //* 投资良机 Investment Opportunity
	{
		//[x]Draw an <b>Overload</b> card.
		//抽一张<b>过载</b>牌。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card card = CardDB.Instance.getCardDataFromID(deckCard);
                if (card.overload > 0)
                {
                    p.drawACard(deckCard, true, false);
                    return;
                }
            }
        }
       		
		
	}
}
