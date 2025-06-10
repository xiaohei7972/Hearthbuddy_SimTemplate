using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_263 : SimTemplate //* 灵魂灌注 Soul Infusion
//Give theleft-most minion in your hand +2/+2.
//使你手牌中最左边的随从牌获得+2/+2。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
					if (hc.card.type == CardDB.cardtype.MOB)
					{
                        hc.addattack += 2;;
                        hc.addHp += 2;
                        p.anzOwnExtraAngrHp += 4;
					}   
                }                
            }
        }
	}
}