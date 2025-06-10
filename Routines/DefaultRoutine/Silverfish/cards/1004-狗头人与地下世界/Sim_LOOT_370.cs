using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_370 : SimTemplate //* 寻求组队 Gather Your Party
	//<b>Recruit</b> a minion.
	//<b>招募</b>一个随从。 
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
					// ID 转卡
					CardDB.cardIDEnum deckCard = kvp.Key;
					CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
					// 招募随从
					if (deckMinion.type == CardDB.cardtype.MOB)
					{
						int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
						p.callKid(deckMinion, pos, ownplay);
						break;
					}
			}
		}
		
		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}