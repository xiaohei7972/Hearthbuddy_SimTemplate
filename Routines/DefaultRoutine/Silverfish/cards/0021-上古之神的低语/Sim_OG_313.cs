using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_313 : SimTemplate //* 腐化灰熊 Addled Grizzly
//After you summon a minion, give it +1/+1.
//在你召唤一个随从后，使其获得+1/+1。 
	{
		
		
		public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
			if (m.own == summonedMinion.own && m.entitiyID != summonedMinion.entitiyID)
			{
				p.minionGetBuffed(summonedMinion, 1, 1);
			}
        }
	}
}