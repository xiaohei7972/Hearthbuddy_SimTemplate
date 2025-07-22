using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//武器 战士 费用：3 攻击力：2 耐久度：0
	//Imbued Axe
	//灌能战斧
	//[x]<b>Infused</b>After your hero attacks,give your damagedminions +2/+2.
	//<b>已注能</b>在你的英雄攻击后，使你受伤的随从获得+2/+2。
	class Sim_REV_933t : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_933t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“灌能战斧”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.REV_933t)
			{
				p.ownMinions.ToList()
				.Where(m => m.wounded == true)
				.ToList()
				.ForEach(m => p.minionGetBuffed(m, 2, 2));

			}

		}

	}
}
