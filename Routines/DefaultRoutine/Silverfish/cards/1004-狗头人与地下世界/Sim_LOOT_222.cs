using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 蜡烛弓 Candleshot
	//Your hero is <b>Immune</b> while attacking.
	//你的英雄在攻击时具有<b>免疫</b>。 
	class Sim_LOOT_222 : SimTemplate
	{
		CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_222);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(c, ownplay);

		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.CORE_LOOT_222)
			{
				own.immuneWhileAttacking = true;
			}

		}

	}
}