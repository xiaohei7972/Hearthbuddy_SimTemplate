using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 血蹄勇士 Bloodhoof Brave
    //<b>Taunt</b>Has +3 Attack while damaged.
    //<b>嘲讽</b>受伤时具有+3攻击力。 
    class Sim_OG_218 : SimTemplate
    {
        public override void onEnrageStart(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, 3, 0);
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, -3, 0);
        }
        
    }
}