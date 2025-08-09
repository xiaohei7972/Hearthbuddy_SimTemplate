using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 腐化灰熊 Addled Grizzly
	//After you summon a minion, give it +1/+1.
	//在你召唤一个随从后，使其获得+1/+1。 
	class Sim_OG_313 : SimTemplate
	{
		public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
		{
			if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own && RaceUtils.IsRaceOrAll(summonedMinion.handcard.card.race, CardDB.Race.PET))
			{
				p.minionGetBuffed(summonedMinion, 1, 1);
			}
		}
	}
}