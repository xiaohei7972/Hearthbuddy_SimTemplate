using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：1 生命值：1
	//Sparkbot
	//火花机器人
	//<b>Magnetic</b><b>Windfury</b>
	//<b>磁力</b><b>风怒</b>
	class Sim_TTN_719t3 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own) p.Magnetic(own); // 磁力

		}
		
	}
}
