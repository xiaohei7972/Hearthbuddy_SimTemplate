using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_tt_004 : SimTemplate //* 腐肉食尸鬼 Flesheating Ghoul
	{
		//Whenever a minion dies, gain +1 Attack.
		//每当一个随从死亡，便获得+1攻击力。

        public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            int diedMinions = p.tempTrigger.ownMinionsDied + p.tempTrigger.enemyMinionsDied;
            if (diedMinions == 0) return;
            int residual = (p.pID == m.pID) ? diedMinions - m.extraParam2 : diedMinions;
            m.pID = p.pID;
            m.extraParam2 = diedMinions;
            if (residual >= 1)
            {
                p.minionGetBuffed(m, residual, 0);
            }
        }
	}
}