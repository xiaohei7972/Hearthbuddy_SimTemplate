using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 牧师 费用：3 攻击力：1 耐久度：0
	//Self-Sharpening Sword
	//自砺之锋
	//After your hero attacks, gain +1 Attack.
	//在你的英雄攻击后，获得+1攻击力。
	class Sim_SCH_622 : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_622);

		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay);
		// }

		public override void afterHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“自砺之锋”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.SCH_622)
				if (p.ownWeapon.Durability >= 1)
				{
					p.ownWeapon.Angr++;
					p.minionGetBuffed(own, 1, 0);
				}

		}

	}
}
