using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_110 : SimTemplate //* 角斗场主管 Coliseum Manager
//<b>Inspire:</b> Return this minion to your hand.
//<b>激励：</b>将该随从移回你的手牌。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				p.minionReturnToHand(m, own, 0);
			}
        }
	}
}