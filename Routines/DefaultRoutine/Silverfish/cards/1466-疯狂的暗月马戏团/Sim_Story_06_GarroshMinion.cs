using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：7 攻击力：6 生命值：5
	//Garrosh Hellscream
	//加尔鲁什·地狱咆哮
	//<b>Charge</b>Has +5 Attack while damaged.
	//<b>冲锋</b>受伤时拥有+5攻击力。
	class Sim_Story_06_GarroshMinion : SimTemplate
	{
		public override void onEnrageStart(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, 5, 0);
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, -5, 0);
        }
		
	}
}
