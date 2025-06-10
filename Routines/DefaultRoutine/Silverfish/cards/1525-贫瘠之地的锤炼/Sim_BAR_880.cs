using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_880 : SimTemplate //* 定罪（等级1） Conviction (Rank 1)
	{
		//[x]Give a random friendlyminion +3 Attack.<i>(Upgrades when youhave 5 Mana.)</i>
		//随机使一个友方随从获得+3攻击力。<i>（当你有5点法力值时升级。）</i>
		// 优先加给不会攻击的
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.evaluatePenality += 16;
			int cnt = 1, count = 1;
			if (p.ownMaxMana >= 10)
			{
				cnt = 3;
				count = 3;
			}
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
		}

	}
}
