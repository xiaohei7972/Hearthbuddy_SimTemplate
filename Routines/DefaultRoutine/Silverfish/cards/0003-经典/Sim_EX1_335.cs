using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_335 : SimTemplate //* 光耀之子 Lightspawn
	{
		//This minion's Attack is always equal to its Health.
		//该随从的攻击力等同于其生命值。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            own.Angr = own.Hp;
		}

	}
}