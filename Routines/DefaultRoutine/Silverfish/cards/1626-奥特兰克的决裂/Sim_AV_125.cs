using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_125 : SimTemplate //* 塔楼中士 towersergeant
	{
		//<b>战吼：</b>如果你控制至少两个其他随从，便获得+2/+2。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int num = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;
			if (num > 1)
			{
				p.minionGetBuffed(own, 2, 2);
			}
		}
	}
}
