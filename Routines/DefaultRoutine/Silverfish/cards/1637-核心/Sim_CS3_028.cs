using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS3_028 : SimTemplate //* 暗中生长 Thrive in the Shadows
	{
        //<b>Discover</b> a spell from your deck.
        //从你的牌库中<b>发现</b>一张法术牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int cnt = 3;
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card card = CardDB.Instance.getCardDataFromID(deckCard);
                if (card.type == CardDB.cardtype.SPELL)
                {
                    p.drawACard(deckCard, true, false);
                    p.owncards[p.owncards.Count - 1].discovered = true;
                    cnt--;
                }
                if (cnt <= 0) return;
            }
        }

    }
}
