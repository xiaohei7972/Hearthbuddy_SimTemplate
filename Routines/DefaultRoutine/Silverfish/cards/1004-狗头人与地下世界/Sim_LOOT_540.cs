using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_540 : SimTemplate //* 驯龙师 Dragonhatcher
//At the end of your turn, <b>Recruit</b> a Dragon.
//在你的回合结束时，<b>招募</b>一条龙。 
	{
		
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_848);

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
				foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
				{
					// ID 转卡
					CardDB.cardIDEnum deckCard = kvp.Key;
					CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
					// 招募龙
					if (deckMinion.type == CardDB.cardtype.MOB && deckMinion.race == CardDB.Race.DRAGON)
					{
						int pos = (triggerEffectMinion.own) ? p.ownMinions.Count : p.enemyMinions.Count;
						p.callKid(deckMinion, pos, triggerEffectMinion.own);
						break;
					}
				}
				//int pos = (triggerEffectMinion.own) ? p.ownMinions.Count : p.enemyMinions.Count;
				//p.callKid(kid, pos, triggerEffectMinion.own, false);
				//if (triggerEffectMinion.own)p.ownDeckSize--;
				//else p.enemyDeckSize--;
			}
		}
	}
}