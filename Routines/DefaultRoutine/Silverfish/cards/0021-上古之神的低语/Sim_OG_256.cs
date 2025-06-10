using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_256 : SimTemplate //* 恩佐斯的子嗣 Spawn of N'Zoth
//<b>Deathrattle:</b> Give your minions +1/+1.
//<b>亡语：</b>使你的所有随从获得+1/+1。 
	{
		
		
		public override void onDeathrattle(Playfield p, Minion m)
        {
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion mn in temp)
            {
				p.minionGetBuffed(mn, 1, 1);
            }
        }
    }
}