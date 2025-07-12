using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 战士 费用：7 攻击力：5 耐久度：0
	//The Unstoppable Force
	//无坚不摧之力
	//After you attack a minion, smash it into the enemy hero!
	//在你攻击一个随从后，将其撞向敌方英雄！
	class Sim_AV_202t2 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_202t2);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“无坚不摧之力”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.AV_202t2)
			{
				if (target != null)
				{
					p.minionAttacksMinion(target, own.own ? p.enemyHero : p.ownHero);
				}
			}
		}

	}
}
