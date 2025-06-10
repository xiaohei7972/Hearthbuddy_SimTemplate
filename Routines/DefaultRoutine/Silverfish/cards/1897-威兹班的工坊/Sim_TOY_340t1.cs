using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：1 生命值：1
	//Nostalgic Initiate
	//恋旧的新生
	//<b>Mini</b>The first time you cast a spell, gain +2/+2.
	//<b>微型</b>在你施放本随从登场后的第一个法术时获得+2/+2。
	class Sim_TOY_340t1 : SimTemplate
	{
        private bool hasGainedBuff = false; // 用于跟踪随从是否已经获得过 +2/+2 的增益

        public override void onMinionWasSummoned(Playfield p, Minion own, Minion summoned)
        {
            if (own.own && summoned.handcard.card.cardIDenum == CardDB.cardIDEnum.TOY_340t1)
            {
                hasGainedBuff = false; // 重置增益状态，确保随从刚登场时没有获得增益
            }
        }

        public override void onCardWasPlayed(Playfield p, CardDB.Card card, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (wasOwnCard && triggerEffectMinion.own && triggerEffectMinion.handcard.card.cardIDenum == CardDB.cardIDEnum.TOY_340t1 && !hasGainedBuff)
            {
                // 在该随从登场后的第一个法术施放后获得 +2/+2
                p.minionGetBuffed(triggerEffectMinion, 2, 2);
                hasGainedBuff = true; // 标记已经获得过增益
            }
        }

    }
}
