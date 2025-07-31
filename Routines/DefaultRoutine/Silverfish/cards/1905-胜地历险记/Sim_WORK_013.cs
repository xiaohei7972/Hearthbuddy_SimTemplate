using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：4 攻击力：3 生命值：4
	//Turbulus
	//湍流元素特布勒斯
	//<b>Hunter Tourist</b>. <b>Battlecry:</b> Give +1/+1 to all other <b>Battlecry</b> minions in your hand, deck, and battlefield.
	//<b>猎人游客</b><b>战吼：</b>使你手牌，牌库和战场上的所有其他<b>战吼</b>随从获得+1/+1。
	class Sim_WORK_013 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				// 增强战场上的所有己方随从
				foreach (Minion minion in p.ownMinions)
				{
					if (minion.handcard.card.type == CardDB.cardtype.MOB && minion.handcard.card.battlecry && minion.entitiyID != own.entitiyID)
						p.minionGetBuffed(minion, 1, 1);
				}

				// 增强手牌中的所有随从
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB && hc.card.battlecry) // 检查是否为随从卡牌
					{
						hc.addattack += 1;
						hc.addHp += 1;
						p.anzOwnExtraAngrHp += 2;
					}
				}

				// 增强牌库中的所有随从
				foreach (CardDB.Card card in p.ownDeck)
				{
					if (card.type == CardDB.cardtype.MOB && card.battlecry) // 检查是否为随从卡牌
					{
						card.Attack += 1; // 增加攻击力
						card.Health += 1; // 增加生命值
					}
				}
			}
		}

	}
}
