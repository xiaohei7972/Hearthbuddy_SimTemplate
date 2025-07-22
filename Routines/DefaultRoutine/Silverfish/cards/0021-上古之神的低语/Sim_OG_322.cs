using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_322 : SimTemplate //* 黑水海盗 Blackwater Pirate
//Your weapons cost (2) less.
//你的武器法力值消耗减少（2）点。 
    {
        
        
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own) p.blackwaterpirate++;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.blackwaterpirate--;
        }
    }
}