using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    // 海盗帕奇斯 (Patches the Pirate) 随从 中立 费用：1 攻击力：1 生命值：1
    // [x]在你使用一张海盗牌后，从你的牌库中召唤本随从。
    class Sim_CFM_637 : SimTemplate
    {
        // 用于标识此随从是否已经从牌库中被召唤过或已进入墓地
        bool summoned = false;

        // 当玩家使用一张随从牌时触发此方法
        public override void onMinionWasSummoned(Playfield p, Minion m, Minion target)
        {
            // 使用 RaceUtils 来判断是否为海盗或融合怪
            if (RaceUtils.IsRaceOrAll(m.handcard.card.race, CardDB.Race.PIRATE) && !summoned)
            {
                // 获取帕奇斯的卡牌信息
                CardDB.Card pcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_637);

                // 检查帕奇斯是否已经在手牌、场上或墓地中
                bool patchesInHandOrPlay = false;

                // 遍历场上随从，检查是否有帕奇斯
                foreach (Minion minion in p.ownMinions)
                {
                    if (minion.handcard.card.cardIDenum == CardDB.cardIDEnum.CFM_637)
                    {
                        patchesInHandOrPlay = true;
                        break;
                    }
                }

                // 遍历手牌，检查是否有帕奇斯
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.cardIDenum == CardDB.cardIDEnum.CFM_637)
                    {
                        patchesInHandOrPlay = true;
                        break;
                    }
                }

                // 如果帕奇斯在墓地中，也将标记为已召唤
                if (!patchesInHandOrPlay && p.ownGraveyard.ContainsKey(CardDB.cardIDEnum.CFM_637))
                {
                    patchesInHandOrPlay = true;
                }

                // 如果帕奇斯不在场上、手牌或墓地中，并且还在牌库中，则召唤帕奇斯
                if (!patchesInHandOrPlay)
                {
                    foreach (CardDB.Card deckCard in p.ownDeck)
                    {
                        if (deckCard.cardIDenum == CardDB.cardIDEnum.CFM_637)
                        {
                            // 从牌库中召唤帕奇斯到战场
                            p.callKid(pcard, p.ownMinions.Count, true);
                            // 从牌库中移除帕奇斯
                            p.ownDeck.Remove(deckCard);
                            // 标记帕奇斯已经被召唤过
                            summoned = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
