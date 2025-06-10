using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_513 : SimTemplate //* 迷失的幽魂 Lost Spirit
//<b>Deathrattle:</b> Give your minions +1 Attack.
//<b>亡语：</b>使你的所有随从获得+1攻击力。 
	{
		
		
		public override void onDeathrattle(Playfield p, Minion m)
        {
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion mn in temp)
            {
				p.minionGetBuffed(mn, 1, 0);
            }
        }
    }
}