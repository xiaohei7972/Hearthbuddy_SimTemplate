using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：2 生命值：3
	//Nostalgic Initiate
	//恋旧的新生
	//<b>Miniaturize</b>The first time you cast a spell, gain +2/+2.
	//<b>微缩</b>在你施放本随从登场后的第一个法术时获得+2/+2。
	class Sim_TOY_340 : SimTemplate
	{
        private bool hasGainedBuff = false; // 用于跟踪随从是否已经获得过 +2/+2 的增益

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理微缩效果：抽一张衍生物牌
            CardDB.Card miniaturizedCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_340t1); // 假设衍生物牌ID为 TOY_340t1
            if (miniaturizedCard != null)
            {
                p.drawACard(miniaturizedCard.cardIDenum, ownplay, true);
            }
        }

        public override void onMinionWasSummoned(Playfield p, Minion own, Minion summoned)
        {
            if (own.own && summoned.handcard.card.cardIDenum == CardDB.cardIDEnum.TOY_340)
            {
                hasGainedBuff = false; // 重置增益状态，确保随从刚登场时没有获得增益
            }
        }

        public override void onCardWasPlayed(Playfield p, CardDB.Card card, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (wasOwnCard && triggerEffectMinion.own && triggerEffectMinion.handcard.card.cardIDenum == CardDB.cardIDEnum.TOY_340 && !hasGainedBuff)
            {
                // 在该随从登场后的第一个法术施放后获得 +2/+2
                p.minionGetBuffed(triggerEffectMinion, 2, 2);
                hasGainedBuff = true; // 标记已经获得过增益
            }
        }

    }
}
