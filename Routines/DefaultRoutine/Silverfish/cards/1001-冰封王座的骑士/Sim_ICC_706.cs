using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_706: SimTemplate //* 蛛魔拆解者 Nerubian Unraveler
//Spells cost (2) more.
//法术的法力值消耗增加（2）点。 
    {
        

        public override void onAuraStarts(Playfield p, Minion own)
        {
            p.ownSpelsCostMore += 2;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            p.ownSpelsCostMore -= 2;
        }
    }
}