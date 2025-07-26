using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 赤环蜂 Redband Wasp
    //<b>Rush</b>Has +3 Attack while damaged.
    //<b>突袭</b>受伤时具有+3攻击力。 
    class Sim_GIL_155 : SimTemplate
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