using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_063 : SimTemplate //* 酸喉 Acidmaw
//Whenever another minion takes damage, destroy it.
//每当有其他随从受到伤害，将其消灭。 
	{
		

        public override void onAuraStarts(Playfield p, Minion own)
		{
            p.anzAcidmaw++;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            p.anzAcidmaw--;
		}
	}
}