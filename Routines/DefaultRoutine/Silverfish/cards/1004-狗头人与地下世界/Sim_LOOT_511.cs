using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_511 : SimTemplate //* 卡瑟娜·冬灵 Kathrena Winterwisp
//<b>Battlecry and Deathrattle:</b> <b>Recruit</b> a Beast.
//<b>战吼，亡语：</b><b>招募</b>一个野兽。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				// 招募野兽
				if (deckMinion.type == CardDB.cardtype.MOB && deckMinion.race == CardDB.Race.BEAST)
				{
					int pos = m.own ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(deckMinion, pos, m.own);
					break;
				}
			}
		}

        public override void onDeathrattle(Playfield p, Minion m)
        {
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				// 招募野兽
				if (deckMinion.type == CardDB.cardtype.MOB && deckMinion.race == CardDB.Race.BEAST)
				{
					int pos = m.own ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(deckMinion, pos, m.own);
					break;
				}
			}
		}
    }
}