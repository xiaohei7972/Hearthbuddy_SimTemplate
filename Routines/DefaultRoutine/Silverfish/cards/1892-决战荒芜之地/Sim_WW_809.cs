using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：3 攻击力：3 生命值：3
	//Bovine Skeleton
	//骷髅牛
	//<b>Deathrattle:</b> If this has 4or more Attack, summona Bovine Skeleton.
	//<b>亡语：</b>如果本随从的攻击力大于或等于4点，召唤一只骷髅牛。
	class Sim_WW_809 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_809);
		public override void onDeathrattle(Playfield p, Minion m)
		{
			if (m.Angr >= 4)
			{
				p.callKid(kid, m.zonepos - 1, m.own);
			}
		}

	}
}
