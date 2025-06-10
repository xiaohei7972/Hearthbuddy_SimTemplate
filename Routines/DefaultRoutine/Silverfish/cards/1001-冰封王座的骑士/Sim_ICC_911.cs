using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_911: SimTemplate //* 哀泣女妖 Keening Banshee
//Whenever you play a card, remove the top 3 cards of_your deck.
//每当你使用一张牌，便移除你的牌库顶的三张牌。 
    {
        

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {
                if (triggerEffectMinion.own)
                {
                    p.ownDeckSize = Math.Max(0, p.ownDeckSize - 3);
                }
                else
                {
                    p.enemyDeckSize = Math.Max(0, p.enemyDeckSize - 3);
                }
            }
        }
    }
}