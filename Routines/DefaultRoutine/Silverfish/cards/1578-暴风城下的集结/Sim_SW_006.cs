using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_006 : SimTemplate //* 顽固的嫌疑人 Stubborn Suspect
	{
		//<b>Deathrattle:</b> Summon a random 3-Cost minion.
		//<b>亡语：</b>随机召唤一个法力值消耗为（3）的随从。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_172);

		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
		}
	}
}
