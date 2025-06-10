using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_030a : SimTemplate //* 攻击模式 Attack Mode
//+1 Attack.
//+1攻击力。 
	{

        
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.minionGetBuffed(own, 1, 0);
		}



	}
}