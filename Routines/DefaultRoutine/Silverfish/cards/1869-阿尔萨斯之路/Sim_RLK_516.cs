using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 巫妖王 费用：1 攻击力：2 耐久度：0
	//Bone Breaker
	//碎骨手斧
	//[x]After your hero attacks aminion, deal 2 damageto the enemy hero.
	//在你的英雄攻击随从后，对敌方英雄造成2点伤害。
	class Sim_RLK_516 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.RLK_516);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“碎骨手斧”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.RLK_516)
			{
				if (!target.isHero && target.Hp <= 0)
				{
					p.minionGetDamageOrHeal(p.enemyHero, 2);
				}

			}

		}

	}
}
