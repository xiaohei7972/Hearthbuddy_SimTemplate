using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：6 生命值：5
	//Nostalgic Clown
	//恋旧的小丑
	//[x]<b>Miniaturize</b><b>Battlecry:</b> If you've played ahigher Cost card while holdingthis, deal 4 damage.
	//<b>微缩</b><b>战吼：</b>如果你在此牌在你手中时使用过法力值消耗更高的牌，造成4点伤害。
	class Sim_TOY_341 : SimTemplate
	{

        private bool higherCostCardPlayed = false; // 用于跟踪是否在手牌中时打出了法力值消耗更高的牌

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理微缩效果：抽一张衍生物牌
            CardDB.Card miniaturizedCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_341t); // 假设衍生物牌ID为 TOY_341t
            if (miniaturizedCard != null)
            {
                p.drawACard(miniaturizedCard.cardIDenum, ownplay, true);
            }
        }

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 检查是否应该造成4点伤害
            if (higherCostCardPlayed && target != null)
            {
                p.minionGetDamageOrHeal(target, 4);
            }
        }

        public override void onCardWasPlayed(Playfield p, CardDB.Card card, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 检查此随从是否在手牌中
            if (wasOwnCard && triggerEffectMinion.own && triggerEffectMinion.handcard.card.cardIDenum == CardDB.cardIDEnum.TOY_341)
            {
                // 检查是否使用过法力值消耗更高的牌
                if (card.cost > triggerEffectMinion.handcard.card.cost)
                {
                    higherCostCardPlayed = true; // 标记为已经使用过更高法力值的牌
                }
            }
        }
    }
}
