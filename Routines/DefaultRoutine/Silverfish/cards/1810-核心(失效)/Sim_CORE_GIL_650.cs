using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：4 攻击力：3 生命值：6
	//Houndmaster Shaw
	//驯犬大师肖尔
	//Your other minions have<b>Rush</b>.
	//你的其他随从拥有<b>突袭</b>。
	class Sim_CORE_GIL_650 : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion m)
		{
			List<Minion> minions = m.own ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in minions)
			{
				if (minion.entitiyID == m.entitiyID) continue;
				p.minionGetRush(minion);
			}
        }

		public override void onAuraEnds(Playfield p, Minion m)
		{
			List<Minion> minions = m.own ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in minions)
			{
				if (minion.entitiyID == m.entitiyID) continue;
				minion.rush = 0;
			}
        }
		
	}
}
