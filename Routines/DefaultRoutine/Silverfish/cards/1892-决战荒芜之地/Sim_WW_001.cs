using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：1 生命值：1
	//Kobold Miner
	//狗头人矿工
	//<b>Battlecry:</b> <b>Excavate</b>a treasure.
	//<b>战吼：</b><b>发掘</b>一个宝藏。
	class Sim_WW_001 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			// 触发发掘效果
			CardDB.Card treasure = p.handleExcavation();
            p.drawACard(treasure.cardIDenum, own.own, true);
		}

	}
}
