using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：5 攻击力：5 生命值：8
	//Quartz Elemental
	//石英元素
	//Can't attack while damaged.
	//受伤时无法攻击。
	class Sim_GIL_156 : SimTemplate
	{
		public override void onEnrageStart(Playfield p, Minion m)
		{
			m.cantAttack = true;
			m.updateReadyness();
        }

		public override void onEnrageStop(Playfield p, Minion m)
		{
			m.cantAttack = false;
			m.updateReadyness();
		}
		
	}
}
