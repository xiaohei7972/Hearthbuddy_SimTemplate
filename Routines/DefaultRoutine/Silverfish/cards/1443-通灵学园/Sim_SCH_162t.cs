using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_162t : SimTemplate //* 魔药龙崽 Plagued Hatchling
	{
        //
        //
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.evaluatePenality -= 5;
            }
            else
            {
                p.evaluatePenality += 10;
            }           
        }

    }
}
