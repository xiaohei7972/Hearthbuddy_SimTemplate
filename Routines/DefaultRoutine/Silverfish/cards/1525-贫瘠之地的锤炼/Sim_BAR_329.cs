using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_329 : SimTemplate //* 亡语者布莱克松 Death Speaker Blackthorn
	{
        //<b>Battlecry:</b> Summon 3 <b>Deathrattle</b> minions that cost (5) or less from your deck.
        //<b>战吼：</b>从你的牌库中召唤三个法力值消耗小于或等于（5）点的<b>亡语</b>随从。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			int cnt = 3;
			// 遍历卡组
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				// 5费以下亡语
				if (deckMinion.deathrattle && deckMinion.type == CardDB.cardtype.MOB && deckMinion.cost <= 5)
				{
					int pos = p.ownMinions.Count;
					p.callKid(deckMinion, pos, own.own);
					//p.minionGetBuffed(p.ownMinions[pos], p.deckAngrBuff, p.deckHpBuff);
					cnt--;
					if (cnt <= 0) break;
				}
			}
		}
	}
}
