using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 战士 费用：7 攻击力：5 耐久度：0
	//Remornia, Living Blade
	//活体利刃蕾茉妮雅
	//After your hero attacks, return this to the battlefield.
	//在你的英雄攻击后，将这把剑移回战场。
	class Sim_REV_316t : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_316t);
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_316);
		
		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay);
		// }

		public override void afterHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“活体利刃蕾茉妮雅”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.REV_316t)
			{
				int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, own.own);
			}
		}

	}
}
