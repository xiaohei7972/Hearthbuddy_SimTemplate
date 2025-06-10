using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_934 : SimTemplate //* 被禁锢的安塔恩 Imprisoned Antaen
	{
		//[x]<b>Dormant</b> for 2 turns.When this awakens, deal10 damage randomly splitamong all enemies.
		//<b>休眠</b>两回合。唤醒时，造成10点伤害，随机分配到所有敌人身上。
		public override void onDormantEndsTrigger(Playfield p, Minion m)
		{
			p.allCharsOfASideGetRandomDamage(!m.own, 10);
		}

	}
}
