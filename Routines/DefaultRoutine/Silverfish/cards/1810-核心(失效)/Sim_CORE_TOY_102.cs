using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：2 生命值：5
	//Footman
	//人类步兵
	//<b>Taunt</b>Adjacent minions are <b>Immune</b> while attacking.
	//<b>嘲讽</b>。相邻随从在攻击时<b>免疫</b>。
	class Sim_CORE_TOY_102 : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion m)
		{
			List<Minion> minions = m.own ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in minions)
			{
				if (minion.entitiyID == m.entitiyID) continue;
				if (minion.zonepos == m.zonepos + 1 || minion.zonepos == m.zonepos - 1)
				{
					minion.immuneWhileAttacking = true;
				}
			}
		}

		public override void onAuraEnds(Playfield p, Minion m)
		{
			List<Minion> minions = m.own ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in minions)
			{
				if (minion.entitiyID == m.entitiyID) continue;
				if (minion.zonepos == m.zonepos + 1 || minion.zonepos == m.zonepos - 1)
				{
					minion.immuneWhileAttacking = false;
				}
			}
		}
		
	}
}
