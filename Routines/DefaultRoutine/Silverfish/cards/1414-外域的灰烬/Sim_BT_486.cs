using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_486 : SimTemplate //* 深渊指挥官 Pit Commander
	{
        //<b>Taunt</b>At the end of your turn, summon a Demon from your deck.
        //<b>嘲讽</b>在你的回合结束时，从你的牌库中召唤一个恶魔。
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if(triggerEffectMinion.own && turnEndOfOwner)
            {
				foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
				{
					// ID 转卡
					CardDB.cardIDEnum deckCard = kvp.Key;
					CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
					if (deckMinion.race == CardDB.Race.DEMON || deckMinion.race == CardDB.Race.ALL)
					{
						int pos = p.ownMinions.Count;
						p.callKid(deckMinion, pos, true);
						break;
					}
				}
			}
        }

    }
}
