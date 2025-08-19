using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 战士 费用：4 攻击力：3 耐久度：0
	//Craftsman's Hammer
	//匠人之锤
	//Whenever your hero attacks, gain 4 Armor.
	//每当你的英雄攻击时，便获得4点护甲值。
	class Sim_TTN_467 : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_467);
		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay);
		// }
		
		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查是否是己方英雄并且装备的是“匠人之锤”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.TTN_467)
			{
				p.minionGetArmor(own.own ? p.ownHero : p.enemyHero, 5);

			}

		}

	}
}
