using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_051 : SimTemplate //* 战斗机器人 Warbot
//Has +1 Attack while damaged.
//受伤时具有+1攻击力。 
    {

        

        public override void onEnrageStart(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, 1, 0);
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, -1, 0);
        }


    }

}