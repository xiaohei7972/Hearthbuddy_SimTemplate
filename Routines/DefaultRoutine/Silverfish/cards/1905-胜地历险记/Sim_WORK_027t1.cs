using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//Modest Tour
	//简便之行
	//Get 2 random cards that can potentially impact the enemy's battlefield.
	//随机获取2张可能会影响敌方战场的卡牌。
	class Sim_WORK_027t1 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
		     p.drawACard(CardDB.cardIDEnum.CORE_CS1_112, ownplay, true);
			 p.drawACard(CardDB.cardIDEnum.EX1_407, ownplay, true);
		}
	}
}
