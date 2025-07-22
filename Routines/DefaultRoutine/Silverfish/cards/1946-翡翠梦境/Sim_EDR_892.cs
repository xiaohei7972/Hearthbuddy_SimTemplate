using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：7 攻击力：7 生命值：5
	//Ferocious Felbat
	//残暴的魔蝠
	//[x]<b>Deathrattle:</b> Resurrect adifferent friendly <b>Deathrattle</b>minion that costs (5) or more.Summon a copy of it.
	//<b>亡语：</b>复活一个不同的法力值消耗大于或等于（5）点的友方<b>亡语</b>随从，并召唤一个它的复制。
	class Sim_EDR_892 : SimTemplate
	{
		CardDB.Card kid = null;
		CardDB.Card GraveyardCard = null;
		public override void onDeathrattle(Playfield p, Minion m)
		{
			foreach (KeyValuePair<CardDB.cardIDEnum, int> e in p.ownGraveyard)
			{
				GraveyardCard = CardDB.Instance.getCardDataFromID(e.Key);
				if (GraveyardCard.deathrattle && GraveyardCard.cost >= 5)
				{
					kid = GraveyardCard;
					break;
				}
			}

			if (kid != null)
			{
				p.callKid(kid, m.zonepos - 1, m.own);
				p.callKid(kid, m.zonepos - 1, m.own);
			}
		}
		
	}
}
