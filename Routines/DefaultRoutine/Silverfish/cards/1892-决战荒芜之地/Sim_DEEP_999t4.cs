using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：4 攻击力：5 生命值：5
	//The Azerite Dragon
	//艾泽里特龙
	//[x]<b>Battlecry:</b> Give all otherminions in your hand, deck,and battlefield +3/+3.
	//<b>战吼：</b>使你手牌，牌库和战场上的所有其他随从获得+3/+3。
	class Sim_DEEP_999t4 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			// 增强战场上的所有己方随从
			foreach (Minion minion in p.ownMinions)
			{
				if (minion.handcard.card.type == CardDB.cardtype.MOB && minion.entitiyID != own.entitiyID)
					p.minionGetBuffed(minion, 3, 3);
			}

			// 增强手牌中的所有随从
			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if (hc.card.type == CardDB.cardtype.MOB) // 检查是否为随从卡牌
				{
					hc.addattack += 3;
					hc.addHp += 3;
					p.anzOwnExtraAngrHp += 6;
				}
			}

			// 增强牌库中的所有随从
			foreach (CardDB.Card card in p.ownDeck)
			{
				if (card.type == CardDB.cardtype.MOB) // 检查是否为随从卡牌
				{
					card.Attack += 3; // 增加攻击力
					card.Health += 3; // 增加生命值
				}
			}
		}

	}
}
