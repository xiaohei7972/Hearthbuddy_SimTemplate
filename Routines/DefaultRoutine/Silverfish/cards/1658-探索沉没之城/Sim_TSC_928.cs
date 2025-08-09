using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：1 生命值：3
	//Security Automaton
	//安保自动机
	//After you summon a Mech, gain +1/+1.
	//在你召唤一个机械后，获得+1/+1。
	class Sim_TSC_928 : SimTemplate
	{
		public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
		{
			if (triggerEffectMinion.own == summonedMinion.own && RaceUtils.IsRaceOrAll(summonedMinion.handcard.card.race, CardDB.Race.MECHANICAL))
			{
				p.minionGetBuffed(triggerEffectMinion, 1, 1);
			}
		}
		
	}
}
