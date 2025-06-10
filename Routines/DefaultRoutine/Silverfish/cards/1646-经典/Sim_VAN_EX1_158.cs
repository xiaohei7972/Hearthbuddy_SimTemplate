using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_158 : SimTemplate //* 丛林之魂 Soul of the Forest
	{
		//Give your minions "<b>Deathrattle:</b> Summon a 2/2 Treant."
		//使你的所有随从获得“<b>亡语：</b>召唤一个2/2的树人”。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                m.souloftheforest++;
            }
		}

	}
}