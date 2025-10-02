using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Evolution Chamber
	//进化腔
	//Give your minions +1_Attack. Give your Zerg an extra +1/+1.
	//使你的随从获得+1攻击力，使你的异虫额外获得+1/+1。
	class Sim_SC_021 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			List<Minion> minions = ownplay ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in minions)
			{
				p.minionGetBuffed(minion, 1, 0);
				if (minion.handcard.card.Zerg)
					p.minionGetBuffed(minion, 1, 1);
			}
		}

	}
}
