using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_VAN_EX1_614 : SimTemplate //* 萨维斯 Xavius
    {
        //After you play a card, summon a 2/1 Satyr.
        //在你使用一张牌后，召唤一个2/1的萨特。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_614t);

        // public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        // {
        //     if (wasOwnCard == triggerEffectMinion.own)
        //     {
        //         p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);

        //     }
        // }
        
        public override void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {
                p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);

            }
        }

	}
}