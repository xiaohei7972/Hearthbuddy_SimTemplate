using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_032 : SimTemplate //* 花岗岩熔铸体 Granite Forgeborn
	{
		//<b>Battlecry:</b> Reduce the cost of Elementals in your hand and deck by (1).
		//<b>战吼：</b>使你手牌和牌库中的元素牌法力值消耗减少（1）点。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if ((TAG_RACE)hc.card.race == TAG_RACE.ELEMENTAL)
                {
                    hc.manacost--;
                }
            }

            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);

                if ((TAG_RACE)deckMinion.race == TAG_RACE.ELEMENTAL)
                {
                    deckMinion.cost--;
                }
            }
        }		
		
	}
}
