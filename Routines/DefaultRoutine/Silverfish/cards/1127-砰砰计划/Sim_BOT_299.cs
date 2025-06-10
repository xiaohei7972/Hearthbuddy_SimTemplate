using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_299 : SimTemplate //* 欧米茄装配 Omega Assembly
//[x]<b>Discover</b> a Mech. If youhave 10 Mana Crystals,keep all 3 cards.
//<b>发现</b>一张机械牌。如果你有十个法力水晶，保留全部三张牌。 
	{
		
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {			
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			if (p.ownMaxMana ==10)
			{	
				p.drawACard(CardDB.cardNameEN.unknown, ownplay);
				p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);						
			}	
        }
	}
}