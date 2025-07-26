using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：2 攻击力：1 生命值：4
	//Crazed Wretch
	//疯狂的可怜鬼
	//Has +2 Attack and <b>Charge</b> while damaged.
	//受伤时拥有+2攻击力和<b>冲锋</b>。
	class Sim_REV_930 : SimTemplate
	{
		public override void onEnrageStart(Playfield p, Minion m)
		{
			p.minionGetBuffed(m, 3, 0);
			p.minionGetCharge(m);
        }
		public override void onEnrageStop(Playfield p, Minion m)
		{
			p.minionGetBuffed(m, -3, 0);
			p.minionLostCharge(m);
        }
		
	}
}
