using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_751 : SimTemplate //* 孵化池觅食者 Spawnpool Forager
	{
		//<b>Deathrattle:</b> Summon a 1/1 Tinyfin.
		//<b>亡语：</b>召唤一个1/1的鱼人宝宝。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOEA10_3);

		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
		}

	}
}
