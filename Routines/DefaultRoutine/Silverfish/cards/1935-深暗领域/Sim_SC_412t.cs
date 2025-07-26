using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：4 攻击力：4 生命值：4
	//Hellbat
	//恶蝠
	//Your other minions have +2 Attack and <b>Rush</b>.
	//你的其他随从拥有+2攻击力和<b>突袭</b>。
	class Sim_SC_412t : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion own)
		{
			if (own.own)
			{
				foreach (Minion m in p.ownMinions)
				{
					p.minionGetBuffed(m, 2, 0);
					p.minionGetRush(m);
				}
			}
			else
			{
				foreach (Minion m in p.enemyMinions)
				{
					p.minionGetBuffed(m, 2, 0);
					p.minionGetRush(m);
				}
			}

		}

		public override void onAuraEnds(Playfield p, Minion own)
		{
			if (own.own)
			{
				foreach (Minion m in p.ownMinions)
				{
					m.rush = 0;
					p.minionGetBuffed(m, -2, 0);
				}
			}
			else
			{
				foreach (Minion m in p.enemyMinions)
				{
					m.rush = 0;
					p.minionGetBuffed(m, -2, 0);
				}
			}
		}
		
	}
}
