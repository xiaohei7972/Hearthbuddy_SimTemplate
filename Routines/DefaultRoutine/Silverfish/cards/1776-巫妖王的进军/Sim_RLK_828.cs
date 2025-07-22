using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 猎人 费用：6 攻击力：4 耐久度：0
	//Hope of Quel'Thalas
	//奎尔萨拉斯的希望
	//[x]After your hero attacks,give your minions +1/+1<i>(wherever they are).</i>
	//在你的英雄攻击后，使你的所有随从获得+1/+1<i>（无论它们在哪）</i>。
	class Sim_RLK_828 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_416);
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_416t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“奎尔萨拉斯的希望”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.RLK_828)
			{
				p.allMinionOfASideGetBuffed(own.own, 1, 1);

				// 增强手牌中的所有随从
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB) // 检查是否为随从卡牌
					{
						hc.addattack += 1;
						hc.addHp += 1;
					}
				}

				// 增强牌库中的所有随从
				foreach (CardDB.Card card in p.ownDeck)
				{
					if (card.type == CardDB.cardtype.MOB) // 检查是否为随从卡牌
					{
						card.Attack += 1; // 增加攻击力
						card.Health += 1; // 增加生命值
					}
				}
			}
		}

	}

}

