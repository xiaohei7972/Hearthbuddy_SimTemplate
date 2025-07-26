using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 格罗玛什·地狱咆哮 Grommash Hellscream
    //<b>Charge</b>Has +6 Attack while damaged.
    //<b>冲锋</b>受伤时具有+6攻击力。
    class Sim_VAN_EX1_414 : SimTemplate
    {
        public override void onEnrageStart(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, 6, 0);
        }
        public override void onEnrageStop(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, -6, 0);
        }

    }
}