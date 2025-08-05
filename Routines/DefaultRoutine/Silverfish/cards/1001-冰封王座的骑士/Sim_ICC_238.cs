using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 活化狂战士 Animated Berserker
    //After you play a minion, deal 1 damage to it.
    //在你使用一张随从牌后，对被召唤的随从造成1点伤害。 
    class Sim_ICC_238 : SimTemplate
    {
        // public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        // {
        //     if (summonedMinion.playedFromHand && summonedMinion.own == m.own && summonedMinion.entitiyID != m.entitiyID)
        //     {
        //         p.minionGetDamageOrHeal(summonedMinion, 1);
        //     }
        // }

        public override void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {
                p.minionGetDamageOrHeal(playedMinion, 1);
            }
        }
    }
}