using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_314 : SimTemplate //* 灰熊守护者 Grizzled Guardian
	{
		//<b>Taunt</b><b>Deathrattle:</b> <b>Recruit</b> 2_minions that cost (4)_or_less.
		//<b>嘲讽，亡语：</b><b>招募</b>两个法力值消耗小于或等于（4）点的随从。
		public override void onDeathrattle(Playfield p, Minion m)
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
					p.callKid(deckMinion, pos + 1, m.own);
					break;
				}
			}
		}
	}
}
