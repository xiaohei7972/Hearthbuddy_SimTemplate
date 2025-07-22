using System;
using System.Collections.Generic;

namespace HREngine.Bots
{
    // 随从 中立 费用：3 攻击力：2 生命值：4
    // Deep Space Curator
    // 深空策展人
    // <b>法术迸发</b>：随机获取一张法力值消耗与法术相同的随从牌，并将其法力值消耗变为（0）点。
    class Sim_GDB_311 : SimTemplate
    {
/*
        public override void onSpellburst(Playfield p, Minion m, int spellCost)
        {
            // 从卡牌数据库中获取所有符合指定费用的随从卡
            List<CardDB.Card> validMinions = new List<CardDB.Card>();
            foreach (CardDB.Card card in CardDB.Instance.cards.Values)
            {
                // 筛选出符合条件的随从卡
                if (card.cost == spellCost && card.type == CardDB.cardtype.MOB)
                {
                    validMinions.Add(card);
                }
            }

            // 如果存在符合条件的随从卡，随机选择一个
            if (validMinions.Count > 0)
            {
                // 随机选择一张符合条件的随从牌
                CardDB.Card chosenMinion = p.getRandomCardFromList(validMinions);

                // 创建手牌实例并将其费用设为0
                Handmanager.Handcard newHandcard = new Handmanager.Handcard(chosenMinion)
                {
                    manacost = 0 // 设置费用为0
                };

                // 将随从牌加入玩家手牌
                p.owncards.Add(newHandcard);

                // 输出调试信息（可选）
                //Console.WriteLine($"法术迸发触发：获得一张随机随从牌 {chosenMinion.name}，费用为 0。");
            }
        }
*/
    }
}
