using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：4 攻击力：3 生命值：3
	//Sonya Waterdancer
	//水上舞者索尼娅
	//After you play a 1-Cost card, get a copy of itthat costs (0).
	//在你使用一张法力值消耗为（1）的卡牌后，获取一张它的法力值消耗为（0）点的复制。
	class Sim_TOY_515 : SimTemplate
	{
        public override void onCardWasPlayed(Playfield p, CardDB.Card card, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 检查是否是己方玩家打出的卡牌
            if (wasOwnCard)
            {
                // 检查卡牌的法力值消耗是否为1
                if (card.getManaCost(p, card.cost) == 1)
                {
                    // 创建一张法力值消耗为0的该卡牌的复制，并添加到手牌中
                    CardDB.Card zeroCostCard = CardDB.Instance.getCardDataFromID(card.cardIDenum);
                    Handmanager.Handcard newCard = new Handmanager.Handcard
                    {
                        card = zeroCostCard,
                        manacost = 0
                    };
                    p.owncards.Add(newCard);
                }
            }
        }

    }
}
