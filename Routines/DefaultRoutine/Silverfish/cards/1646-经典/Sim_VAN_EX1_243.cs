using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_243 : SimTemplate //* 尘魔 Dust Devil
	{
		//<b>Windfury</b>. <b>Overload:</b> (2)
		//<b>风怒</b>，<b>过载：</b>（2）
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.ueberladung += 2;
		}

	}
}