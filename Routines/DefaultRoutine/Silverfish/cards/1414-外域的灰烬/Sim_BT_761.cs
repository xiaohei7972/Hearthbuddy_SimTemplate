using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_761  : SimTemplate// BT_761  盘牙督军
//突袭，亡语：召唤一个5/9并具有嘲讽

	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_761t);


		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
		}
	}
}