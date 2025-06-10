using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_029 : SimTemplate //* 暗影视界 Shadow Visions
//<b>Discover</b> a copy of a spell in your deck.
//从你的牌库中<b>发现</b>一张法术牌的复制。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int cnt = 3;
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card card = CardDB.Instance.getCardDataFromID(deckCard);
                if (card.type == CardDB.cardtype.SPELL && card.nameCN != CardDB.cardNameCN.暗影视界)
                {
                    p.drawACard(deckCard, true, true);
                    p.owncards[p.owncards.Count - 1].discovered = true;
                    cnt--;
                }
                if (cnt <= 0) return;
            }
        }
	}
}