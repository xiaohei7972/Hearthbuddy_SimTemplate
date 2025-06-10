using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_118 : SimTemplate //* 历战先锋 battlewornvanguard
	{
		//在你的英雄攻击后，召唤两只1/1的 邪翼蝠。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_922t);
		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			p.callKid(kid, own.zonepos, own.own);
			p.callKid(kid, own.zonepos-1, own.own);
		}
	}
}
