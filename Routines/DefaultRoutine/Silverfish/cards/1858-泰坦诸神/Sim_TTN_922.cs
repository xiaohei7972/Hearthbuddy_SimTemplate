using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TTN_922 : SimTemplate //* 换挡漂移 Gear Shift
    {
        // Shuffle the two left-most cards in your hand into your deck. Draw 3 cards.
        // 将你最左边的两张手牌洗入你的牌库。抽三张牌。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 获取玩家的手牌列表
            List<Handmanager.Handcard> tempHand = ownplay ? p.owncards : p.enemyHand;

            // 确保手牌数量足够（至少2张）以避免索引超出范围
            if (tempHand.Count >= 2)
            {
                // 将最左边的两张手牌洗入牌库
                Handmanager.Handcard card1 = tempHand[0];
                Handmanager.Handcard card2 = tempHand[1];

                // 将选定的两张手牌洗回牌库
                p.AddToDeck(card1.card);
                p.AddToDeck(card2.card);
                p.removeCard(card1);
                p.removeCard(card2);
            }
            else if (tempHand.Count == 1)
            {
                // 如果只有一张手牌，则只将这张牌洗入牌库
                Handmanager.Handcard card = tempHand[0];
                p.AddToDeck(card.card);
                p.removeCard(card);
            }

            // 抽三张新牌
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
        }
    }
}
