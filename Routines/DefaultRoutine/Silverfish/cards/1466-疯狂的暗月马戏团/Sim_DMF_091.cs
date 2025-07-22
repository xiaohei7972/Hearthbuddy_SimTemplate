using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_091 : SimTemplate //* 蠕动的恐魔 Wriggling Horror
	{
		//<b>Battlecry:</b> Give adjacent minions +1/+1.
		//<b>战吼：</b>使相邻的随从获得+1/+1。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp)
			{
				if(m.zonepos == own.zonepos -1 || m.zonepos == own.zonepos + 1)
				{
					p.minionGetBuffed(m, 1, 1);
				}
			}
        }
		
	}
}
