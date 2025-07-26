using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：1 生命值：2
	//Temple Berserker
	//神殿狂战士
	//<b>Reborn</b>Has +2 Attack while damaged.
	//<b>复生</b>受伤时拥有+2攻击力。
	class Sim_ULD_185 : SimTemplate
	{
        public override void onEnrageStart(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, 2, 0);
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, -2, 0);
        }
		
	}
}
