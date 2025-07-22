using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：3 攻击力：3 耐久度：2
	//Magnifying Glaive
	//放大战刃
	//[x]After your hero attacks,draw until you have3 cards.
	//在你的英雄攻击后，抽牌，直到你拥有三张牌。
	class Sim_CORE_REV_509 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CORE_REV_509);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)//英雄攻击
		{
			//如果手牌小于3 优先进攻
			if (p.owncards.Count < 3)
			{
				p.evaluatePenality--;
			}


			// 检查己方英雄是否装备了“放大战刃”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.CORE_REV_509)
			{
				if (p.owncards.Count < 3)
				{
					for (int i = p.owncards.Count; i < 3; i++)
					{
						p.drawACard(CardDB.cardNameEN.unknown, own.own);
					}
				}
			}

		}

	}
}
