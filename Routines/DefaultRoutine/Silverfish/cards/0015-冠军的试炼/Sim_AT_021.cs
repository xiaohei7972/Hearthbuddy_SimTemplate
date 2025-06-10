using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AT_021 : SimTemplate //* 小鬼骑士 Tiny Knight of Evil
//Whenever you discard a card, gain +1/+1.
//每当你弃掉一张牌时，便获得+1/+1。 
	{
        
        
        public override bool onCardDicscard(Playfield p, Handmanager.Handcard hc, Minion own, int num, bool checkBonus)
        {
            if (own == null) return false;
            if (checkBonus) return false;

            p.minionGetBuffed(own, num, num);
            return false;
        }
    }
}