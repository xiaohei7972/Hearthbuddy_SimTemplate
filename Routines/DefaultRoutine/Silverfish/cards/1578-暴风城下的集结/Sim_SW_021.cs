using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_021 : SimTemplate //* 怯懦的步兵 Cowardly Grunt
	{
		//<b>Deathrattle:</b> Summon a minion from your deck.
		//<b>亡语：</b>从你的牌库中召唤一个随从。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			// 遍历卡组
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				// 看看还有没有随从?
				if (deckMinion.type == CardDB.cardtype.MOB)
				{
					int pos = p.ownMinions.Count;
					p.callKid(deckMinion, pos, own.own);
					//p.minionGetBuffed(p.ownMinions[pos], p.deckAngrBuff, p.deckHpBuff);
					break;
				}
			}
		}		
		
	}
}
