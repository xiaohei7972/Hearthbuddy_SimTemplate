using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_095 : SimTemplate //* 加基森拍卖师 Gadgetzan Auctioneer
	{
		//Whenever you cast a spell, draw a card.
		//每当你施放一个法术，抽一张牌。

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.SPELL && wasOwnCard == triggerEffectMinion.own)
            {
                p.drawACard(CardDB.cardIDEnum.None, wasOwnCard);
            }

        }

	}
}