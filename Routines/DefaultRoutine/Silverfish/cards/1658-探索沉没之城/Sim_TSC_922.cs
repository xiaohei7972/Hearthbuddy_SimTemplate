using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：2 攻击力：0 生命值：3
	//Anchored Totem
	//驻锚图腾
	//After you summon a 1-Cost minion, give it +2/+1.
	//在你召唤一个法力值消耗为（1）的随从后，使其获得+2/+1。
	class Sim_TSC_922 : SimTemplate
	{
		public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
		{
			if (triggerEffectMinion.own == summonedMinion.own)
				if (summonedMinion.handcard.card.cost == 1)
					p.minionGetBuffed(summonedMinion, 2, 1);

		}

	}
}
