using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_113 : SimTemplate //* 夜色镇议员 Darkshire Councilman
//[x]After you summon a minion, gain +1 Attack.
//在你召唤一个随从后，获得+1攻击力。 
	{
		

        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            if (m.entitiyID != summonedMinion.entitiyID && m.own == summonedMinion.own)
            {
				p.minionGetBuffed(m, 1, 0);
            }
        }
    }
}