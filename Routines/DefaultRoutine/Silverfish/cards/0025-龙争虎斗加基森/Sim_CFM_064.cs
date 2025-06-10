using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_064 : SimTemplate //* 黑金大亨 Blubber Baron
//Whenever you summon a <b>Battlecry</b> minion while this_is in your hand, gain_+1/+1.
//每当你召唤一个具有<b>战吼</b>的随从时，便使这张牌（在你手牌中时）获得+1/+1。 
	{
		

        

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
        {
            if (hc.card.battlecry && hc.card.type == CardDB.cardtype.MOB)
            {
                hc.addattack++;
                hc.addHp++;
            }
        }
    }
}