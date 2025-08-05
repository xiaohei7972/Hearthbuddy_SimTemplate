using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 哀嚎蒸汽 Wailing Vapor
    //[x]After you play an Elemental,gain +1 Attack.
    //在你使用一张元素牌后，获得+1攻击力。
    class Sim_WC_042 : SimTemplate
    {
        // public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion m)
        // {
        //     if (m.own)
        //     {
        //         if (hc.card.race == CardDB.Race.ELEMENTAL || hc.card.race == CardDB.Race.ALL)
        //         {
        //             p.minionGetBuffed(m, 1, 0);
        //         }
        //     }
        // }

        public override void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {
                if ((CardDB.Race)playedMinion.handcard.card.race == CardDB.Race.ELEMENTAL || (CardDB.Race)playedMinion.handcard.card.race == CardDB.Race.ALL)
                {
                    p.minionGetBuffed(triggerEffectMinion, 1, 1);
                }
            }
        }
    }
}
