using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_119 : SimTemplate //* 克瓦迪尔劫掠者 Kvaldir Raider
//<b>Inspire:</b> Gain +2/+2.
//<b>激励：</b>获得+2/+2。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				p.minionGetBuffed(m, 2, 2);
			}
        }
	}
}