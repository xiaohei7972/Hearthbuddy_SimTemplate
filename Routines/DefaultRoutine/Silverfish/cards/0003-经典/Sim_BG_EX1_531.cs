using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：2 攻击力：2 生命值：2
	//Scavenging Hyena
	//食腐土狼
	//Whenever a friendly Beast dies, gain +2/+1.
	//每当一个友方野兽死亡，便获得+2/+1。
	class Sim_BG_EX1_531 : SimTemplate
	{
		public override void onMinionDiedTrigger(Playfield p, Minion triggerEffectMinion, Minion diedMinion)
		{
			//
			int diedMinions = p.tempTrigger.ownBeastDied + p.tempTrigger.enemyBeastDied;
			if (diedMinions == 0) return;
			int residual = (p.pID == triggerEffectMinion.pID) ? diedMinions - triggerEffectMinion.extraParam2 : diedMinions;
			triggerEffectMinion.pID = p.pID;
			triggerEffectMinion.extraParam2 = diedMinions;
			if (residual >= 1)
			{
				p.minionGetBuffed(triggerEffectMinion, 2 * residual, 0);
			}
		}

	}
}
