using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：2 生命值：3
	//Undercover Cultist
	//卧底教徒
	//<b>Taunt</b>, <b>Reborn</b>Has +3 Attack while damaged.
	//<b>嘲讽</b>。<b>复生</b>。受伤时拥有+3攻击力。
	class Sim_TLC_101 : SimTemplate
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
