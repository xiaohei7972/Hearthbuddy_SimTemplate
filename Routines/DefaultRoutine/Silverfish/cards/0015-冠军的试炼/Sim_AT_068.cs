using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_068 : SimTemplate //* 加固 Bolster
//Give your <b>Taunt</b> minions +2/+2.
//使你具有<b>嘲讽</b>的随从获得+2/+2。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
				if (m.taunt) p.minionGetBuffed(m, 2, 2);
            }
        }
    }
}
