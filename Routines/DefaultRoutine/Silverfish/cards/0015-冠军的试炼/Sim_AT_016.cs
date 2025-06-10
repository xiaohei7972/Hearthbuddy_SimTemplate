using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_016 : SimTemplate //* 迷乱 Confuse
//Swap the Attack and Health of all minions.
//将所有随从的攻击力和生命值互换。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinions)
            {
				p.minionSwapAngrAndHP(m);
            }
            foreach (Minion m in p.enemyMinions)
            {
				p.minionSwapAngrAndHP(m);
            }
        }
    }
}