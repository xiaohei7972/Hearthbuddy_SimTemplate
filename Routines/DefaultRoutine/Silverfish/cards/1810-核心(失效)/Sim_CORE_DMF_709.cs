using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：3 攻击力：0 生命值：4
	//Grand Totem Eys'or
	//巨型图腾埃索尔
	//At the end of your turn,give +1/+1 to all other Totems in your hand, deck and battlefield.
	//在你的回合结束时，使你手牌，牌库和战场上的所有其他图腾获得+1/+1。
	class Sim_CORE_DMF_709 : SimTemplate
	{
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			if (triggerEffectMinion.own == turnEndOfOwner)
			{
				// 增强战场上的己方其他图腾随从
				foreach (Minion minion in p.ownMinions)
				{
					if (minion.handcard.card.type == CardDB.cardtype.MOB && RaceUtils.IsRaceOrAll(CardDB.Race.TOTEM, minion.handcard.card.race) && minion.entitiyID != triggerEffectMinion.entitiyID)
						p.minionGetBuffed(minion, 1, 1);
				}

				// 增强手牌中的所有随从
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB && RaceUtils.IsRaceOrAll(CardDB.Race.TOTEM, hc.card.race)) // 检查是否为图腾卡牌
					{
						hc.addattack += 1;
						hc.addHp += 1;
						p.anzOwnExtraAngrHp += 2;
					}
				}

				// 增强牌库中的所有随从
				foreach (CardDB.Card card in p.ownDeck)
				{
					if (card.type == CardDB.cardtype.MOB && RaceUtils.IsRaceOrAll(CardDB.Race.TOTEM, card.race)) // 检查是否为图腾卡牌
					{
						card.Attack += 1; // 增加攻击力
						card.Health += 1; // 增加生命值
					}
				}
			}

		}

	}
}
