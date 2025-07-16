using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//法术 猎人 费用：5
	//Supreme Dinomancy
	//顶级恐龙学
	//Give +2/+2 to all Beasts in your hand, deck, and battlefield.
	//使你手牌，牌库和战场上的所有野兽获得+2/+2。
	class Sim_TLC_828 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				List<Minion> ownPetMinions = p.ownMinions.Where((minion) => (CardDB.Race)minion.handcard.card.race == CardDB.Race.PET).ToList();
				List<Handmanager.Handcard> ownPetCards = p.owncards.Where((hc) => hc.card.type == CardDB.cardtype.MOB && (CardDB.Race)hc.card.race == CardDB.Race.PET).ToList();
				List<CardDB.Card> ownPetDeck = p.ownDeck.Where((card) => card.type == CardDB.cardtype.MOB && (CardDB.Race)card.race == CardDB.Race.PET).ToList();
				// 增强战场上的所有己方野兽
				foreach (Minion minion in ownPetMinions)
				{
					// if ((CardDB.Race)minion.handcard.card.race == CardDB.Race.PET)
					p.minionGetBuffed(minion, 2, 2);
				}

				// 增强手牌中的野兽随从
				foreach (Handmanager.Handcard hc in ownPetCards)
				{
					// if (hc.card.type == CardDB.cardtype.MOB && (CardDB.Race)hc.card.race == CardDB.Race.PET) // 检查是否为随从卡牌
					hc.addattack += 2;
					hc.addHp += 2;
					p.anzOwnExtraAngrHp += 4;
				}
				// 增强牌库中的野兽随从
				foreach (CardDB.Card card in ownPetDeck)
				{
					// if (card.type == CardDB.cardtype.MOB && (CardDB.Race)card.race == CardDB.Race.PET) // 检查是否为随从卡牌
					card.Attack += 2; // 增加攻击力
					card.Health += 2; // 增加生命值
				}
			}
		}

	}
}

