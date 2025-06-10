
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TTN_800t3 : SimTemplate // 避免报错
    {
        // 在这里可以定义卡牌的属性，如法力值消耗、卡牌类型、效果等等

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card card = CardDB.Instance.getCardDataFromID(deckCard);
        
                // 检查当前牌是否为过载牌
                if (card.overload > 0)
                {
                    // 将过载牌抽取到玩家手牌中
                    p.drawACard(deckCard, true, false);
                    p.drawACard(deckCard, true, false);
                    p.drawACard(deckCard, true, false);

                    // 如果已经抽取了3张过载牌，则退出循环
                    break;
                }
            }
        }
        
    }
}
