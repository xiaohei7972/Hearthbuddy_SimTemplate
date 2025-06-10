using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_160b : SimTemplate //* 兽群领袖 Leader of the Pack
	{
		//Give your minions +1/+1.
		//使你所有的随从获得+1/+1。
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                p.minionGetBuffed(m, 1, 1);
            }
		}

	}
}