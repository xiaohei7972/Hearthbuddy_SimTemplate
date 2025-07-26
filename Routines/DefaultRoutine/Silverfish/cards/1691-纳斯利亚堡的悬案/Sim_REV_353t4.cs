using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：3 攻击力：2 生命值：4
	//Barghast
	//巴加斯特
	//Your other minions have +1 Attack.
	//你的其他随从拥有+1攻击力。
	class Sim_REV_353t4 : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion own)
		{
			if (own.own)
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

		public override void onAuraEnds(Playfield p, Minion own)
		{
			if (own.own)
			{
				foreach (Minion m in p.ownMinions)
				{
					p.minionGetBuffed(m, -1, 0);
				}
			}
			else
			{
				foreach (Minion m in p.enemyMinions)
				{
					p.minionGetBuffed(m, -1, 0);
				}
			}
		}
		
	}
}
