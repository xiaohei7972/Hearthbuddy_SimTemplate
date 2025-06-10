using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_083: SimTemplate //* 末日学徒 Doomed Apprentice
//Your opponent's spells cost (1) more.
//你对手法术的法力值消耗增加（1）点。 
    {
        

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (!own.own) p.ownSpelsCostMore++;
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (!own.own) p.ownSpelsCostMore--;
        }
    }
}