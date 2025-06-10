using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_493  : SimTemplate// BT_493  愤怒的女祭司
//在你的回合结束时，造成6点伤害，随机分配到所有敌人身上。

	{
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
            if (triggerEffectMinion.own)
            {
				p.allCharsOfASideGetRandomDamage(false, 6);
			}
			else
			{
				p.allCharsOfASideGetRandomDamage(true, 6);
			}
        }
	}
}