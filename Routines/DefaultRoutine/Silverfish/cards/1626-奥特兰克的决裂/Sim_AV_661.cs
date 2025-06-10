using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_661 : SimTemplate //* 征战平原 fieldofstrife
	{
		//你的随从获得+1攻击力。持续3回合。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                foreach (Minion m in p.ownMinions)
                {
                    p.minionGetBuffed(m, 1, 0);
                }
            }
            else
            {
                foreach (Minion m in p.enemyMinions)
                {
                    p.minionGetBuffed(m, 1, 0);
                }
            }
        }

		
	}
}
