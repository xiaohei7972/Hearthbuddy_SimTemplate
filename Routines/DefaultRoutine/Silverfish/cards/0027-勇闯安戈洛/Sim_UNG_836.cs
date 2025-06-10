using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_836 : SimTemplate //* 萨瓦丝女王 Clutchmother Zavas
//Whenever you discard this, give it +2/+2 and return it to your hand.
//每当你弃掉这张牌时，使其获得+2/+2，并将其移回你的手牌。 
	{
		


        public override bool onCardDicscard(Playfield p, Handmanager.Handcard hc, Minion own, int num, bool checkBonus)
        {
            if (checkBonus) return true;
			if (own != null) return false;

            p.drawACard(CardDB.cardNameEN.clutchmotherzavas, true, true);
            int i = p.owncards.Count - 1;
            p.owncards[i].addattack = hc.addattack +2;
            p.owncards[i].addHp = hc.addHp + 2;
            return true;
        }
    }
}