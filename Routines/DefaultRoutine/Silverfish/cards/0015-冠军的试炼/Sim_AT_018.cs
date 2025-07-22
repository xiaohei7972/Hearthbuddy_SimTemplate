using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_018 : SimTemplate //* 银色神官帕尔崔丝 Confessor Paletress
//<b>Inspire:</b> Summon a random <b>Legendary</b> minion.
//<b>激励：</b>随机召唤一个<b>传说</b>随从。 
	{
		

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_014);
		
		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{				
				p.callKid(kid, m.zonepos, m.own);
			}
        }
	}
}