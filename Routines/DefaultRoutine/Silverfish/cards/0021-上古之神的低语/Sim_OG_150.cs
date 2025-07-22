using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_150 : SimTemplate //* 畸变狂战士 Aberrant Berserker
//Has +2 Attack while damaged.
//受伤时具有+2攻击力。 
	{
		
		
        public override void onEnrageStart(Playfield p, Minion m)
        {
            m.Angr += 2;
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            m.Angr -= 2;
        }
	}
}