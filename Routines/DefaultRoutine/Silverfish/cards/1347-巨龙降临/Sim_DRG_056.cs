using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 中立 费用：2 攻击力：2 生命值：2
    //Parachute Brigand
    //空降歹徒
    //[x]After you play a Pirate, summon this minion from your hand.
    //在你使用一张海盗牌后，从你的手牌中召唤本随从。
    class Sim_DRG_056 : SimTemplate
    {
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 使用 RaceUtils 来检查是否为海盗或融合怪
            if (wasOwnCard && RaceUtils.IsRaceOrAll(hc.card.race, CardDB.Race.PIRATE))
            {
                // 遍历手牌，查找空降歹徒
                for (int i = 0; i < p.owncards.Count; i++)
                {
                    Handmanager.Handcard handcard = p.owncards[i];

                    // 如果找到“空降歹徒”且场上随从数量小于7
                    if (handcard.card.cardIDenum == CardDB.cardIDEnum.DRG_056 && p.ownMinions.Count < 7)
                    {
                        // 召唤“空降歹徒”并从手牌中移除
                        p.callKid(handcard.card, p.ownMinions.Count, true);
                        p.removeCard(handcard);
                        break; // 每次只召唤一个空降歹徒
                    }
                }
            }
        }
    }
}
