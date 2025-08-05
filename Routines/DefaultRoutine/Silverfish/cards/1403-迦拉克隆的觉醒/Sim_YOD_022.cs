using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 冒进的艇长 Risky Skipper
	//After you play a minion, deal 1 damage to all_minions.
	//在你使用一张随从牌后，对所有随从造成1点伤害。
	class Sim_YOD_022 : SimTemplate
	{
		// public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
		// {
		// 	if (m.own == ownplay && (TAG_RACE)hc.card.race == TAG_RACE.PIRATE) p.allMinionsGetDamage(1);
		// }

		public override void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (triggerEffectMinion.own == wasOwnCard)
			{
				p.allMinionsGetDamage(1);
			}
		}

	}
}
