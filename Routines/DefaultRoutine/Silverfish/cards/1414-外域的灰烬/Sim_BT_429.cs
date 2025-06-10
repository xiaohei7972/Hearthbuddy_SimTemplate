using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_429  : SimTemplate// BT_429  恶魔变形
//将你的英雄技能替换为“造成4点伤害。”使用两次后，换回原技能。

	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.setNewHeroPower(CardDB.cardIDEnum.BT_429p, ownplay);
		}
	}
}