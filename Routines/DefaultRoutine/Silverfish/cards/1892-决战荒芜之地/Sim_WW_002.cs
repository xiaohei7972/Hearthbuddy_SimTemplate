using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：6 生命值：5
	//Burrow Buster
	//破地钻机
	//<b>Rush</b><b>Battlecry:</b> <b>Excavate</b>a treasure.
	//<b>突袭</b>。<b>战吼：</b><b>发掘</b>一个宝藏。
	class Sim_WW_002 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			// 触发发掘效果
			p.drawACard(p.handleExcavation().cardIDenum, own.own, true);

		}

	}
}
