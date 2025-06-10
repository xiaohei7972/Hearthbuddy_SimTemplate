using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_139 : SimTemplate //* 憎恶军官 abominablelieutenant
	{
		//在你的回合结束时，吞食一个敌方随从并获得其属性值。
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			if (turnEndOfOwner == triggerEffectMinion.own)
			{
			    Minion m = p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestHP);
			    if (m != null) p.minionGetDestroyed(m);
			}
		}
	}
}
