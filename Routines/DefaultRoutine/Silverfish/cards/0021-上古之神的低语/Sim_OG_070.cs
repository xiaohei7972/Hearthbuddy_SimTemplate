using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_070 : SimTemplate //* 执刃教徒 Bladed Cultist
//<b>Combo:</b> Gain +1/+1.
//<b>连击：</b>获得+1/+1。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{			
            if (p.cardsPlayedThisTurn > 0)
            {
                p.minionGetBuffed(own, 1, 1);
            }
		}
	}
}