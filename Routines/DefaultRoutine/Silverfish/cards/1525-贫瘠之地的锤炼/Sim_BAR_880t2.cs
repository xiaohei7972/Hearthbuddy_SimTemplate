using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_880t2 : SimTemplate //* 定罪（等级3） Conviction (Rank 3)
	{
		//Give three random friendly minions +3_Attack.
		// 随机我哪会写啊，优先加给不会攻击的吧
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.evaluatePenality += 16;
			int cnt = 3, count = 3;
			// 优先加给不会攻击的吧
			foreach (Minion m in p.ownMinions)
			{
				if (m.cantAttackHeroes || m.cantAttack || !m.Ready || m.dormant != 0)
				{
					cnt = cnt - 1;
					if (cnt <= 0) break;
					p.evaluatePenality -= 2;
				}
			}
			foreach (Minion m in p.ownMinions)
			{
				if (cnt <= 0) break;
				if (!(m.cantAttackHeroes || m.cantAttack || !m.Ready || m.dormant != 0))
				{
					count--;
					cnt = cnt - 1;
					p.minionGetBuffed(m, 3, 0);
				}
			}
			if (count == 0)
			{
				p.evaluatePenality -= 16;
			}

		}

	}
}
