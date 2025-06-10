using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_030b : SimTemplate //* 坦克模式 Tank Mode
//+1 Health.
//+1生命值。 
	{

        
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.minionGetBuffed(own, 0, 1);
		}


	}
}