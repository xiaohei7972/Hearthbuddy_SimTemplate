using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_014 : SimTemplate //* 除奇致胜 Against All Odds
	{
        //Destroy ALLodd-Attack minions.
        //消灭所有攻击力为奇数的随从。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            bool found = false;
            foreach(Minion m in p.ownMinions)
            {
                if(m.Angr % 2 == 1)
                {
                    p.minionGetDestroyed(m);
                    found = true;
                }
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.Angr % 2 == 1)
                {
                    p.minionGetDestroyed(m);
                    found = true;
                }
            }
            if (!found)
            {
                p.evaluatePenality += 1000;
            }
        }

    }
}
