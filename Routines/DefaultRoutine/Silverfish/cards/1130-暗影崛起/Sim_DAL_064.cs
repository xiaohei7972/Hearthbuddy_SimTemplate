using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_064 : SimTemplate //爆破之王砰砰
	{

		//  Battlecry: Summon two 1/1 Boom Bots. WARNING: Bots may explode. 

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_110t);//chillwind

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.callKid(kid, own.zonepos, own.own);
			p.callKid(kid, own.zonepos - 1, own.own);
		}


	}
}