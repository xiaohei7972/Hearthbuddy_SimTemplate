using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：3 攻击力：4 生命值：2
	//Dreadscale
	//恐鳞
	//At the end of your turn, deal 1 damage to all enemies.
	//在你的回合结束时，对所有敌人造成1点伤害。
	class Sim_WON_025 : SimTemplate
	{
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			if (triggerEffectMinion.own == turnEndOfOwner)
			{
				p.allCharsOfASideGetDamage(!triggerEffectMinion.own, 1);
			}
		}

	}
}
