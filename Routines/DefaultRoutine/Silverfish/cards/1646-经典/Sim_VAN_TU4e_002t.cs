using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN__TU4e_002t : SimTemplate //* 埃辛诺斯之焰 Flame of Azzinoth
	{
		//
		//
		
		
        // [From python script '4.复制狂野Sim到核心与经典Sim.py' by Milin] 复制于'Sim_TU4e_002t.cs'
		//
		//
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }

	}
}
