using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：10 攻击力：10 生命值：10
	//Runaway Blackwing
	//窜逃的黑翼龙
	//[x]At the end of your turn,deal 10 damage to arandom enemy minion.
	//在你的回合结束时，随机对一个敌方随从造成10点伤害。
	class Sim_CORE_YOP_034 : SimTemplate
	{
		public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
		{
			// 只在随从所有者的回合结束时触发
			if (turnEndOfOwner == m.own && p.enemyMinions.Count != 0)
			{
				foreach (Minion minion in p.enemyMinions)
				{
					p.minionGetDamageOrHeal(minion, 10);
					break;
				}

			}
		}
		
	}
}
