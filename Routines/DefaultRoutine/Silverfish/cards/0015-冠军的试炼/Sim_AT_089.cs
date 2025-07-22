using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_089 : SimTemplate //* 白骨卫士军官 Boneguard Lieutenant
//<b>Inspire:</b> Gain +1 Health.
//<b>激励：</b>获得+1生命值。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				p.minionGetBuffed(m, 0, 1);
			}
        }
	}
}