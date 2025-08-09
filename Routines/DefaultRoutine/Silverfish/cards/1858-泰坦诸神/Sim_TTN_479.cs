using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	// Flame Soul
	// 在你召唤一个元素后，使其获得+1/+1。
	class Sim_TTN_479 : SimTemplate
	{
		// public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
		// {
		// 	// 判断被召唤的随从是否为元素，并且是否与当前随从（Flame Soul）属于同一玩家
		// 	if ((TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.ELEMENTAL && summonedMinion.own == m.own)
		// 	{
		// 		// 对该元素随从进行增益+1/+1
		// 		p.minionGetBuffed(summonedMinion, 1, 1);
		// 	}
		// }

		public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
		{
			if (triggerEffectMinion.own == summonedMinion.own && RaceUtils.IsRaceOrAll(summonedMinion.handcard.card.race, CardDB.Race.ELEMENTAL))
			{
				p.minionGetBuffed(summonedMinion, 1, 1);
			}
		}
	}
}
