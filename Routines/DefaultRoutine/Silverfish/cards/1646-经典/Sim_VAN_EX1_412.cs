using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 暴怒的狼人 Raging Worgen
    //Has +1 Attack and <b>Windfury</b> while damaged.
    //受伤时具有+1攻击力和<b>风怒</b>。
    class Sim_VAN_EX1_412 : SimTemplate
    {
        public override void onEnrageStart(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, 1, 0);
            p.minionGetWindfurry(m);

        }
        public override void onEnrageStop(Playfield p, Minion m)
        {
            m.windfury = false;
            p.minionGetBuffed(m, -1, 0);
        }


    }
}