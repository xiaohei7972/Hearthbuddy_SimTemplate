using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_184 : SimTemplate //* 白银先锋 Silver Vanguard
//<b>Deathrattle:</b> <b>Recruit</b> an8-Cost minion.
//<b>亡语：</b><b>招募</b>一个法力值消耗为（8）的随从。 
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				// 8费
				if (deckMinion.type == CardDB.cardtype.MOB && deckMinion.cost == 8)
				{
					int pos = m.own ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(deckMinion, pos, m.own);
					break;
				}
			}
		}
	}
}