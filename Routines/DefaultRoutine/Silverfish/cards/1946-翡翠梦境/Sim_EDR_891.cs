using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：5 攻击力：5 生命值：3
	//Ravenous Felhunter
	//贪婪的地狱猎犬
	//<b>Deathrattle:</b> Resurrect a friendly <b>Deathrattle</b> minion that costs (4) or less. Summon a copy of it.
	//<b>亡语：</b>复活一个法力值消耗小于或等于（4）点的友方<b>亡语</b>随从，并召唤一个它的复制。
	class Sim_EDR_891 : SimTemplate
	{
		CardDB.Card kid = null;
		CardDB.Card GraveyardCard = null;
		public override void onDeathrattle(Playfield p, Minion m)
		{
			foreach (KeyValuePair<CardDB.cardIDEnum, int> e in p.ownGraveyard)
			{
				GraveyardCard = CardDB.Instance.getCardDataFromID(e.Key);
				if (GraveyardCard.deathrattle && GraveyardCard.cost <= 4)
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
