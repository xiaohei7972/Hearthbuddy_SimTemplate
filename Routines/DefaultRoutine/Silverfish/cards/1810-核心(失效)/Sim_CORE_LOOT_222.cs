using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 猎人 费用：1 攻击力：1 耐久度：0
	//Candleshot
	//蜡烛弓
	//Your hero is <b>Immune</b> while attacking.
	//你的英雄在攻击时<b>免疫</b>。
	class Sim_CORE_LOOT_222 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CORE_LOOT_222);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
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
