using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_026 : SimTemplate //* 冰霜新星 Frost Nova
	{
		//<b>Freeze</b> all enemy minions.
		//<b>冻结</b>所有敌方随从。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
            foreach (Minion t in temp)
            {
                p.minionGetFrozen(t);
            }
        }
    }
}