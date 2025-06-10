using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_054 : SimTemplate //* 暴风城卫兵 Stormwind Guard
	{
		//<b>Taunt</b><b>Battlecry:</b> Give adjacent minions +1/+1.
		//<b>嘲讽</b>，<b>战吼：</b>使相邻的随从获得+1/+1。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp)
			{
				if (m.zonepos == own.zonepos - 1 || m.zonepos == own.zonepos + 1)
				{
					p.minionGetBuffed(m, 1, 1);
				}
			}
		}

	}
}
