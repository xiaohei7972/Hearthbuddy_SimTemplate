using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_375 : SimTemplate //* 公会招募员 Guild Recruiter
//<b>Battlecry:</b> <b>Recruit</b> a minion that costs (4) or less.
//<b>战吼：</b><b>招募</b>一个法力值消耗小于或等于（4）点的随从。 
	{
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				// 4费以下
				if (deckMinion.type == CardDB.cardtype.MOB && deckMinion.cost <= 4)
				{
					int pos = m.own ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(deckMinion, pos, m.own);
					break;
				}
			}
		}

	}
}