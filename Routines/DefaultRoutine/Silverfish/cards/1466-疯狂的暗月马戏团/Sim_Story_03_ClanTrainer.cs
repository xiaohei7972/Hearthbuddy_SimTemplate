using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：4 生命值：4
	//Clan Trainer
	//氏族训练官
	//Your other minions have +1 Attack.
	//你的其他随从拥有+1攻击力。
	class Sim_Story_03_ClanTrainer : SimTemplate
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
