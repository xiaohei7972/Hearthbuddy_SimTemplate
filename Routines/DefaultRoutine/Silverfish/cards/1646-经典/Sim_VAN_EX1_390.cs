using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 牛头人战士 Tauren Warrior
    //<b>Taunt</b>Has +3 Attack while damaged.
    //<b>嘲讽</b>受伤时具有+3攻击力。
    class Sim_VAN_EX1_390 : SimTemplate
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