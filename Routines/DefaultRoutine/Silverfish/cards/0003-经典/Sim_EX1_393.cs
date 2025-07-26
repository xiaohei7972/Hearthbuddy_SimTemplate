using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 阿曼尼狂战士 Amani Berserker
    //Has +3 Attack while damaged.
    //受伤时具有+3攻击力。
    class Sim_EX1_393 : SimTemplate
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