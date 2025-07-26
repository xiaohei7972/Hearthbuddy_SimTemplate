using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：4 攻击力：2 生命值：6
	//Bloodhoof Brave
	//血蹄勇士
	//<b>Taunt</b>Has +3 Attack while damaged.
	//<b>嘲讽</b>受伤时拥有+3攻击力。
	class Sim_CORE_OG_218 : SimTemplate
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
