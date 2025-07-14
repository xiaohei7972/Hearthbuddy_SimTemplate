using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：5 攻击力：3 耐久度：0
	//Warglaives of Azzinoth
	//埃辛诺斯战刃
	//After attacking a minion, your hero may attack again.
	//在攻击一个随从后，你的英雄可以再次攻击。
	class Sim_TOY_400t7 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_400t7);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);

		}
		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“埃辛诺斯战刃”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.TOY_400t7)
			{
				if (target != null)
				{
					// 如果目标是随从
					if (!target.isHero)
					{
						own.cantAttack = true;
					}
				}

			}
		}

	}
}
