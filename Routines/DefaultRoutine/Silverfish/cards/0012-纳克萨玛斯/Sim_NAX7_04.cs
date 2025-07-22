using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX7_04 : SimTemplate //* 符文巨剑 Massive Runeblade
//Deals double damage to heroes.
//对英雄造成双倍伤害。 
	{
		
		

		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NAX7_04);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(weapon, ownplay);
		}
	}
}