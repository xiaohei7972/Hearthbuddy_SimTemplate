using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//Hectic Tour
	//紧凑之行
	//Get 2 random cards that can potentially deal damage to the enemy hero.
	//随机获取2张可能会对敌方英雄造成伤害的卡牌。
	class Sim_WORK_027t3 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
		    p.drawACard(CardDB.cardIDEnum.CORE_CS2_029, ownplay, true);
			p.drawACard(CardDB.cardIDEnum.CORE_EX1_238, ownplay, true);
		}
	}
}
