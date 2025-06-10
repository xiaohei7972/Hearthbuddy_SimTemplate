using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：3
	//Ensmallen
	//缩小术
	//Reduce the Cost and Attack of minions in your deck by (1).
	//使你牌库中随从牌的法力值消耗和攻击力减少（1）点。
	class Sim_TOY_805 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 遍历玩家的牌库，找到所有随从牌
            foreach (var card in p.ownDeck)
            {
                CardDB.Card deckCard = CardDB.Instance.getCardDataFromID(card.cardIDenum);

                // 检查是否为随从牌
                if (deckCard.type == CardDB.cardtype.MOB)
                {
                    // 减少随从牌的法力值消耗和攻击力
                    deckCard.cost = Math.Max(0, deckCard.cost - 1);
                    deckCard.Attack = Math.Max(0, deckCard.Attack - 1);
                }
            }
        }

    }
}
