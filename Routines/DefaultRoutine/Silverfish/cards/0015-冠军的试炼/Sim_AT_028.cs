using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AT_028 : SimTemplate //* 影踪骁骑兵 Shado-Pan Rider
//<b>Combo:</b> Gain +3 Attack.
//<b>连击：</b>获得+3攻击力。 
    {
		
			
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{			
            if (p.cardsPlayedThisTurn > 0)
            {
                p.minionGetBuffed(own, 3, 0);
            }
		}
	}
}