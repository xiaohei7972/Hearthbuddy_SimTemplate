using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_006 : SimTemplate //* 博物馆馆长 Museum Curator
//<b>Battlecry: Discover</b> a <b>Deathrattle</b> card.
//<b>战吼：发现</b>一张<b>亡语</b>牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.lepergnome, own.own, true);
		}
	}
}