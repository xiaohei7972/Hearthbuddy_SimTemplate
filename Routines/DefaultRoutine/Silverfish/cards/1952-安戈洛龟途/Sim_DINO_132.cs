using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：8 攻击力：6 生命值：10
	//Asphyxiodon
	//绝息剑龙
	//[x]<b>Taunt</b>. At the end of yourturn, deal 5 damage to arandom enemy minion.
	//<b>嘲讽</b>。在你的回合结束时，随机对一个敌方随从造成5点伤害。
	class Sim_DINO_132 : SimTemplate
	{
		public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
		{
			// 只在随从所有者的回合结束时触发
			if (turnEndOfOwner == m.own )
			{
				if (m.own ? p.enemyMinions.Count >= 0 : p.ownMinions.Count != 0)
				{
					foreach (Minion minion in m.own ? p.enemyMinions : p.ownMinions)
					{
						if (minion.untouchable) continue;
						p.minionGetDamageOrHeal(minion, 5);
						break;
					}
				}
			}
		}

	}
}
