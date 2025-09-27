using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：3 攻击力：2 生命值：2
	//Funkfin
	//放克鱼人
	//<b>Divine Shield</b>Your minions with<b>Divine Shield</b> have +2_Attack.
	//<b>圣盾</b>。你的<b>圣盾</b>随从拥有+2攻击力。
	class Sim_ETC_337 : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion m)
		{
			List<Minion> minions = m.own ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in minions)
			{
				if (minion.divineshild)
					p.minionGetBuffed(minion, 0, 2);
			}
		}

		public override void onAuraEnds(Playfield p, Minion m)
		{
			List<Minion> minions = m.own ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in minions)
			{
				if (minion.divineshild)
					p.minionGetBuffed(minion, 0, -2);
			}
		}

	}
}
