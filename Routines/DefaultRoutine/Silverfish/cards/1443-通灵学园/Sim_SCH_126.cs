using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 教导主任加丁 Disciplinarian Gandling
    //[x]After you play a minion,destroy it and summon a4/4 Failed Student.
    //在你使用一张随从牌后，将其消灭并召唤一个4/4的挂掉的学生。
    class Sim_SCH_126 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_126t);

        // public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        // {
        //     if (triggerEffectMinion.own && summonedMinion.own && summonedMinion.playedThisTurn && summonedMinion.handcard.card.nameCN != CardDB.cardNameCN.挂掉的学生)
        //     {
        //         p.minionGetDestroyed(summonedMinion);
        //         if (summonedMinion.Hp + summonedMinion.Angr < 8)
        //         {
        //             p.evaluatePenality += (summonedMinion.Hp + summonedMinion.Angr - 8) * 4;
        //         }
        //         p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_126t), triggerEffectMinion.zonepos, true);
        //     }
        // }
        public override void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {
                p.minionGetDestroyed(playedMinion);
                if (playedMinion.Hp + playedMinion.Angr < 8)
                {
                    p.evaluatePenality += (playedMinion.Hp + playedMinion.Angr - 8) * 4;
                }
                p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);

            }
        }
    }
}
