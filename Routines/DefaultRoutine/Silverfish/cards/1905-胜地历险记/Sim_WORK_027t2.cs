using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//Extravagant Tour
	//奢华之行
	//Get 2 random cards that can potentially spend a lot of Mana.
	//随机获取2张可能会消耗大量法力值的卡牌。
	class Sim_WORK_027t2 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
		    p.drawACard(CardDB.cardIDEnum.CORE_EX1_383, ownplay, true);
			p.drawACard(CardDB.cardIDEnum.EX1_295, ownplay, true);
		}
		
	}
}
