using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_052 : SimTemplate //* 图腾魔像 Totem Golem
//<b>Overload:</b> (1)
//<b>过载：</b>（1） 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.ueberladung++;
		}
	}
}