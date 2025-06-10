using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_726  : SimTemplate// BT_726  龙喉巡天者
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_726t);
		public override void onDeathrattle(Playfield p, Minion m)//亡语：召唤一个3/4的龙骑士。
		{
			p.callKid(kid, m.zonepos - 1, m.own);
		}
	}
}