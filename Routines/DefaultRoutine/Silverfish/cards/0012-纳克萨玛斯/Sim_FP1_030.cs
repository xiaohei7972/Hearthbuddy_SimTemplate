using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_030 : SimTemplate //* 洛欧塞布 Loatheb
//<b>Battlecry:</b> Enemy spells cost (5) more next turn.
//<b>战吼：</b>下个回合敌方法术的法力值消耗增加（5）点。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.loatheb = true;
		}

	

	}
}