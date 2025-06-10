using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_573a : SimTemplate //* 半神的恩赐 Demigod's Favor
	{
		//Give your other minions +2/+2.
		//使你的所有其他随从获得+2/+2。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (target.entitiyID != m.entitiyID) p.minionGetBuffed(m, 2, 2);
            }
		}

	}
}