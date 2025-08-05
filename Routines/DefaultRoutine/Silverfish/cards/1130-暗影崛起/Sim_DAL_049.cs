using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 下水道渔人 Underbelly Angler
    //After you play a Murloc, add a random Murloc to your hand.
    //在你使用一张鱼人牌后，随机将一张鱼人牌置入你的手牌。 
    class Sim_DAL_049 : SimTemplate
    {
        // public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        // {
        //     if (triggerEffectMinion.own == summonedMinion.own && (TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.MURLOC)
        //     {
        //         p.drawACard(CardDB.cardNameEN.murlocwarleader, triggerEffectMinion.own);
        //     }
        // }

        public override void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {
                if ((CardDB.Race)playedMinion.handcard.card.race == CardDB.Race.MURLOC || (CardDB.Race)playedMinion.handcard.card.race == CardDB.Race.ALL)
                {
                    p.drawACard(CardDB.cardNameEN.murlocwarleader, triggerEffectMinion.own);
                }
            }
        }

    }
}