using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_843 : SimTemplate //* 战歌大使 Warsong Envoy
	{
		//[x]<b>Frenzy:</b> Gain +1  Attackfor each damaged character.
		//<b>暴怒：</b>每有一个受伤的角色，便获得+1攻击力。
		public override void onEnrageStart(Playfield p, Minion m)
		{
			int gain = 0;
			int gain1 = 0;			
			foreach (Minion mn in p.ownMinions)
			{
				if (m.wounded) gain++;
			}
			foreach (Minion mn in p.enemyMinions)
			{
				if (m.wounded) gain1++;
			}
			int gg = gain + gain1;
			if (gg >= 1) p.minionGetBuffed(m, gg, 0);
		}
	}
}
