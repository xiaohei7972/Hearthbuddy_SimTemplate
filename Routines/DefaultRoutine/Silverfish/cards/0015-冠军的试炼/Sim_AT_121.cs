using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_121 : SimTemplate //* 人气选手 Crowd Favorite
//Whenever you play a card with <b>Battlecry</b>, gain +1/+1.
//每当你使用一张具有<b>战吼</b>的牌，便获得+1/+1。 
	{
		

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.battlecry)
            {
				p.minionGetBuffed(triggerEffectMinion, 1, 1);
            }
        }
	}
}