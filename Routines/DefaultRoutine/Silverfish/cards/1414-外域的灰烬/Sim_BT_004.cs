using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_004  : SimTemplate// BT_004  被禁锢的眼魔
//休眠两回合。唤醒时，对所有敌方随从造成2点伤害。

	{
		public override void onDormantEndsTrigger(Playfield p, Minion m)
		{
			p.allMinionOfASideGetDamage(!m.own, 2);
		}
	}
}