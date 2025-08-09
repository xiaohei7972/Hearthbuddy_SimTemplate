using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：3 攻击力：3 生命值：3
	//Kabal Outfitter
	//暗金教物资官
	//[x]<b>Battlecry and Deathrattle:</b>Give another random_friendly minion +1/+1.
	//<b>战吼，亡语：</b>随机使另一个友方随从获得+1/+1。
	class Sim_BAR_915 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			List<Minion> tmp = own.own ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in tmp)
			{
				if (own.entitiyID == minion.entitiyID) continue;
				p.minionGetBuffed(minion, 1, 1);
				break;
			}

		}

		public override void onDeathrattle(Playfield p, Minion m)
		{
			List<Minion> tmp = m.own ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in tmp)
			{
				if (m.entitiyID == minion.entitiyID) continue;
				p.minionGetBuffed(minion, 1, 1);
				break;
			}
			
		}

	}
}
