using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//武器 战士 费用：3 攻击力：2 耐久度：0
	//Imbued Axe
	//灌能战斧
	//[x]After your hero attacks,give your damaged minions+1/+2. <b>Infuse (@):</b>+2/+2 instead.
	//在你的英雄攻击后，使你受伤的随从获得+1/+2。<b>注能（@）：</b>改为+2/+2。
	class Sim_REV_933 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_933);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“灌能战斧”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.REV_933)
			{
				p.ownMinions.ToList()
				.Where(m => m.wounded == true)
				.ToList()
				.ForEach(m => p.minionGetBuffed(m, 1, 2));

			}

		}

	}
}
