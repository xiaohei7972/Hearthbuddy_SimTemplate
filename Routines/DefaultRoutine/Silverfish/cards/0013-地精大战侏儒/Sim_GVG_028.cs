using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_028 : SimTemplate //* 加里维克斯 Trade Prince Gallywix
//Whenever your opponent casts a spell, gain a copy of it and give them a Coin.
//每当你的对手施放一个法术，获得该法术的复制，并使其获得一个幸运币。 
    {

        

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            CardDB.Card c = hc.card;
            if (c.type == CardDB.cardtype.SPELL && c.nameEN != CardDB.cardNameEN.gallywixscoin && wasOwnCard != triggerEffectMinion.own)
            {
                p.drawACard(c.cardIDenum, triggerEffectMinion.own, true);
                p.drawACard(CardDB.cardNameEN.gallywixscoin, wasOwnCard, true);
            }
        }


    }

}