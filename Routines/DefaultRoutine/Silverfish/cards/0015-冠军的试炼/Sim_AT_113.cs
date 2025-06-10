using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_113 : SimTemplate //* 征募官 Recruiter
//<b>Inspire:</b> Add a 2/2 Squire to your hand.
//<b>激励：</b>将一个2/2的侍从置入你的手牌。 
	{
		
		
		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{				
				p.drawACard(CardDB.cardNameEN.squire, own, true);
			}
        }
	}
}