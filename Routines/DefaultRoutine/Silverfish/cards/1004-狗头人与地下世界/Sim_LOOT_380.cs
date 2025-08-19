using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 灾厄斩杀者 Woecleaver
	//After your hero attacks, <b>Recruit</b> a minion.
	//在你的英雄攻击后，<b>招募</b>一个随从。
	class Sim_LOOT_380 : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_380);

		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay);
		// }
		public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
		{
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				// 招募随从
				if (deckMinion.type == CardDB.cardtype.MOB)
				{
					int pos = hero.own ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(deckMinion, pos, hero.own);
					break;
				}
			}
		}

	}
}
