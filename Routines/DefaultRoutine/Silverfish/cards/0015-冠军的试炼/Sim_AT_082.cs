using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_082 : SimTemplate //* 低阶侍从 Lowly Squire
//<b>Inspire:</b> Gain +1 Attack.
//<b>激励：</b>获得+1攻击力。 
	{
		
				
		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				p.minionGetBuffed(m, 1, 0);
			}
        }
	}
}