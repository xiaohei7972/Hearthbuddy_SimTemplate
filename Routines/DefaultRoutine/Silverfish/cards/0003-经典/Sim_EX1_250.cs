using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_250 : SimTemplate //* 土元素 Earth Elemental
	{
		//<b>Taunt</b><b><b>Overload</b>:</b> (2)
		//<b>嘲讽</b>，<b>过载：</b>（2）
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.ueberladung += 2;
		}


	}
}
