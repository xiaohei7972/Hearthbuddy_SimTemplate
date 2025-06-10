using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_134 : SimTemplate //* 利齿宝箱 Toothy Chest
	{
		//At the start of your turn, set this minion's Attack to 4.
		//在你的回合开始时，将该随从的攻击力变为4。
		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
		{
			if (triggerEffectMinion.own == turnStartOfOwner)
			{
				if (triggerEffectMinion.Angr != 4) triggerEffectMinion.Angr = 4;
			}
		}

	}
}
