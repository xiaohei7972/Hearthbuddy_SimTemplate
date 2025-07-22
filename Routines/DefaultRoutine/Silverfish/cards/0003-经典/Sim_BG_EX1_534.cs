using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：6 攻击力：6 生命值：5
	//Savannah Highmane
	//长鬃草原狮
	//<b>Deathrattle:</b> Summon two 2/2 Hyenas.
	//<b>亡语：</b>召唤两只2/2的土狼。
	class Sim_BG_EX1_534 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_534t);

        public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid,m.zonepos-1,m.own);
			p.callKid(kid,m.zonepos-1,m.own);
		}
		
	}
}
