using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 优胜劣汰 Survival of the Fittest
	//Give +4/+4 to all minions in your hand, deck, and battlefield.
	//使你手牌，牌库以及战场中的所有随从获得+4/+4。
	class Sim_SCH_609 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.evaluatePenality -= 5;
			if (ownplay)
			{
				// 场地
				foreach (Minion m in p.ownMinions)
				{
					p.minionGetBuffed(m, 4, 4);
				}
				// 手牌
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					hc.addattack += 4;
					hc.addHp += 4;
					p.anzOwnExtraAngrHp += 8;
				}
				// 卡组
				foreach (CardDB.Card card in p.ownDeck)
				{
					if (card.type == CardDB.cardtype.MOB) // 检查是否为随从卡牌
					{
						card.Attack += 4; // 增加攻击力
						card.Health += 4; // 增加生命值
					}
				}
			}
		}
	}
}
