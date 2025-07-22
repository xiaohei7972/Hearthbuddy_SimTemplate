using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：3 攻击力：4 生命值：2
	//Workhorse
	//劳作老马
	//<b>Deathrattle:</b> Summon two 2/1 Ponies.
	//<b>亡语：</b>召唤两匹2/1的小马。
	class Sim_WORK_018 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WORK_018t);
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
			p.callKid(kid, m.zonepos - 1, m.own);
		}

	}
}
