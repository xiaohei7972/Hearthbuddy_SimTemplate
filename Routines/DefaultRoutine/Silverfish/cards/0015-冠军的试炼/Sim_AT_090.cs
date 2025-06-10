using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_090 : SimTemplate //* 穆克拉的勇士 Mukla's Champion
//<b>Inspire:</b> Give your other minions +1/+1.
//<b>激励：</b>使你的其他随从获得+1/+1。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				List<Minion> temp = (own) ? p.ownMinions : p.enemyMinions;
				foreach (Minion mnn in temp)
				{
                    if (m.entitiyID == mnn.entitiyID) continue;
					p.minionGetBuffed(mnn, 1, 1);
				}
			}
        }
	}
}