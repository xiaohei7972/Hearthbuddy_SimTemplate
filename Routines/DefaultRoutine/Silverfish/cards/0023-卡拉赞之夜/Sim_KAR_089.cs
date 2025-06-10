using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_089 : SimTemplate //* 玛克扎尔的小鬼 Malchezaar's Imp
//Whenever you discard a card, draw a card.
//每当你弃掉一张牌时，抽一张牌。 
	{
		

        public override bool onCardDicscard(Playfield p, Handmanager.Handcard hc, Minion own, int num, bool checkBonus)
        {
            if (own == null) return false;
            if (checkBonus) return false;
			
            p.drawACard(CardDB.cardIDEnum.None, own.own);
            return false;
        }
    }
}