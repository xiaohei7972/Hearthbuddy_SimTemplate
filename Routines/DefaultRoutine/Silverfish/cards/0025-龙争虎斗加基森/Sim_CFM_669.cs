using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_669 : SimTemplate //* 穴居人强盗 Burgly Bully
//Whenever your opponent casts a spell, add a Coin to your hand.
//每当你的对手施放一个法术，将一个幸运币置入你的手牌。 
	{
		

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.SPELL && wasOwnCard != triggerEffectMinion.own)
            {
                p.drawACard(CardDB.cardNameEN.thecoin, triggerEffectMinion.own);
            }
        }
    }
}