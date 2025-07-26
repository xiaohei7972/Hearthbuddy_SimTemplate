using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：2 生命值：2
	//Pylon Module
	//输能模块
	//Your other minionshave +1 Attack.
	//你的其他随从拥有+1攻击力。
	class Sim_TOY_330t95 : SimTemplate
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
