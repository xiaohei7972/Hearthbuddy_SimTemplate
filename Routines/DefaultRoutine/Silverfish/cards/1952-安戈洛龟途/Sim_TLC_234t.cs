using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：4 攻击力：0 生命值：1
	//Eternal Seedling
	//永生花芽
	//<b>Deathrattle:</b> Summon a 5/1 Eternal Bloodpetal.
	//<b>亡语：</b>召唤一个5/1的永生血瓣花。
	class Sim_TLC_234t : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_234);
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
		}

	}
}
