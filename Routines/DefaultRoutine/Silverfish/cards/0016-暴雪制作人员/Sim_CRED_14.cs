using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：3 生命值：2
	//Yong Woo
	//Yong Woo
	//Your other minions have +3 Attack and <b>Charge</b>.
	//你的其他随从拥有+3攻击力和<b>冲锋</b>。
	class Sim_CRED_14 : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion own)
		{
			if (own.own)
			{
				foreach (Minion m in p.ownMinions)
				{
					p.minionGetBuffed(m, 1, 0);
					p.minionGetCharge(m);
				}
			}
			else
			{
				foreach (Minion m in p.enemyMinions)
				{
					p.minionGetBuffed(m, 1, 0);
					p.minionGetCharge(m);
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
					p.minionLostCharge(m);

				}
			}
			else
			{
				foreach (Minion m in p.enemyMinions)
				{
					p.minionGetBuffed(m, -1, 0);
					p.minionLostCharge(m);
				}
			}
		}
		
	}
}
