using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_414 : SimTemplate //* 格罗玛什·地狱咆哮 Grommash Hellscream
	{
		//<b>Charge</b>Has +6 Attack while damaged.
		//<b>冲锋</b>受伤时具有+6攻击力。
		
        public override void onEnrageStart(Playfield p, Minion m)
        {
            m.Angr+=6;
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            m.Angr-=6;
        }

	}
}