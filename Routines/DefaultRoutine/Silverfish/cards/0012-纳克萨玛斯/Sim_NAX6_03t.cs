using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX6_03t : SimTemplate //* 孢子 Spore
//<b>Deathrattle:</b> Give all enemy minions +8 Attack.
//<b>亡语：</b>使所有敌方随从获得+8攻击力。 
	{


        public override void onDeathrattle(Playfield p, Minion m)
		{
			List<Minion> temp = (m.own) ? p.enemyMinions : p.ownMinions;
            foreach (Minion mm in temp)
            {
                p.minionGetBuffed(mm, 8, 0);
            }
		}
	}
}