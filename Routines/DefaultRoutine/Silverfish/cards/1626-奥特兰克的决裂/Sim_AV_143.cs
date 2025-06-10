using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_143 : SimTemplate //* 血怒者科尔拉克 korrakthebloodrager
	{
		//<b>亡语：</b>如果该随从未被<b>荣誉消灭</b>，则再次召唤科尔拉克。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_143);
		public override void onDeathrattle(Playfield p, Minion m)
		{
			if(m.Hp!=0) p.callKid(kid, m.zonepos - 1, m.own);
		}

	}
}
