using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 嗜睡的神枪手 Dozing Marksman
    //Has +4 Attack while damaged.
    //受伤时具有+4攻击力。 
    class Sim_TRL_406 : SimTemplate
    {
        public override void onEnrageStart(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, 4, 0);
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, -4, 0);
        }

    }
}