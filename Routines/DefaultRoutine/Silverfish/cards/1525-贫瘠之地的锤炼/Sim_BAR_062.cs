using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_062 : SimTemplate //* 甜水鱼人佣兵 Lushwater Murcenary
	{
		//<b>Battlecry:</b> If you control a Murloc, gain +1/+1.
		//<b>战吼：</b>如果你控制一个鱼人，便获得+1/+1。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MURLOC && m.entitiyID != own.entitiyID)
                {
					p.minionGetBuffed(own, 1, 1);
                    break;
                }
            }
        }		
		
	}
}
