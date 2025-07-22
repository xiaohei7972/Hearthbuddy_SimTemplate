using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_046 : SimTemplate //* 嗜血 Bloodlust
	{
		//Give your minions +3_Attack this turn.
		//在本回合中，使你的所有随从获得+3攻击力。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? p.ownMinions: p.enemyMinions;
            foreach (Minion m in temp)
            {
                p.minionGetTempBuff(m, 3, 0);
            }
		}

	}
}