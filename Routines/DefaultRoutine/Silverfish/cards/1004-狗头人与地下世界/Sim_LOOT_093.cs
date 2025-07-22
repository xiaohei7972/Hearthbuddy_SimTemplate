using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_093 : SimTemplate //* Argent Watchman
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int cnt = 3;
			//string str = "我寻思出战斗号角应该能出: ";
			// 遍历卡组
			foreach(KeyValuePair<CardDB.cardIDEnum, int>kvp in p.prozis.turnDeck )
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				if( deckMinion.cost <= 2  && deckMinion.type == CardDB.cardtype.MOB)
				{
					int pos = p.ownMinions.Count ;
					p.callKid(deckMinion, pos, ownplay);
					//str += deckMinion.nameCN + " ";
					cnt--;
					if(cnt <= 0)break;
				}
			}
			if (cnt == 0 && p.ownMinions.Count < 7) p.evaluatePenality -= 30;
			else if(p.prozis.turnDeck.Count == 0 && p.ownMinions.Count < 4) p.evaluatePenality -= 200; // 牌库读取失败
			//Helpfunctions.Instance.ErrorLog(str);
		}


		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
			};
		}
	}
}