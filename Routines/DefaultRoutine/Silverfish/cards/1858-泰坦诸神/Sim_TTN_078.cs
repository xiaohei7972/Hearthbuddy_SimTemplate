using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：2 攻击力：1 生命值：4
	//Observer of Myths
	//神话观测者
	//[x]After you summon aminion with more Attackthan this, give all friendlyminions +1 Attack.
	//在你召唤一个攻击力高于本随从的随从后，使所有友方随从获得+1攻击力。
	class Sim_TTN_078 : SimTemplate
	{
		public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
		{
			if (triggerEffectMinion.own == summonedMinion.own)
			{

				if (summonedMinion.Angr > triggerEffectMinion.Angr)
				{
					foreach (Minion minion in p.ownMinions)
					{
						p.minionGetBuffed(minion, 1, 0);
					}
				}
			}

		}

	}
}
