using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_072 : SimTemplate //* 深渊探险 Journey Below
//<b>Discover</b> a <b>Deathrattle</b> card.
//<b>发现</b>一张<b>亡语</b>牌。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.lepergnome, ownplay, true);
		}
	}
}