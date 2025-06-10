using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_237 : SimTemplate //* 狂欢报幕员
	{
		//Whenever you summon a 1-Health minion, give it Divine Shield.

        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            if (summonedMinion.Hp == 1 && m.own == summonedMinion.own && m.entitiyID != summonedMinion.entitiyID)
            {
				p.minionGetBuffed(summonedMinion, 1, 2);
            }
        }
        
    }
}