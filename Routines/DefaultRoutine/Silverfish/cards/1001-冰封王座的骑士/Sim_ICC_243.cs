using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_243: SimTemplate //* 巨型尸蛛 Corpse Widow
//Your <b>Deathrattle</b> cards cost_(2) less.
//你的<b>亡语</b>牌的法力值消耗减少（2）点。 
    {
        

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own) p.ownDRcardsCostMore -= 2;
            else { } 
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own) p.ownDRcardsCostMore += 2;
            else { } 
        }
    }
}