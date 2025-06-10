using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_DAL_086 : SimTemplate //* 夺日者间谍
	{
		//战吼：如果你控制一个奥秘，便获得+1+1.
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.minionGetBuffed(own, 1, 1);
		}
	}
}