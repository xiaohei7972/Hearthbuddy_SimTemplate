using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_222 : SimTemplate //* 蜡烛弓 Candleshot
//Your hero is <b>Immune</b> while attacking.
//你的英雄在攻击时具有<b>免疫</b>。 
	{
        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_222);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(c,ownplay);
			
		}

	}
}