using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_310 : SimTemplate //* 光沐元素 Lightshower Elemental
	{
		//[x]<b>Taunt</b><b>Deathrattle:</b> Restore #8 Healthto all friendly characters.
		//<b>嘲讽</b>，<b>亡语：</b>为所有友方角色恢复#8点生命值。
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.minionGetDamageOrHeal(m.own ? p.enemyHero : p.ownHero, -8);
			List<Minion> temp = m.own ? p.ownMinions : p.enemyMinions;
			foreach (Minion mm in temp)
			{
				p.minionGetDamageOrHeal(mm, -8);
			}
		}
		
	}
}
