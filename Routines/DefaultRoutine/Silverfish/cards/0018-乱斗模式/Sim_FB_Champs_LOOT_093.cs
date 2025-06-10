using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_LOOT_093 : SimTemplate //* 战斗号角 Call to Arms
	{
		//[x]<b>Recruit</b> 3 minions that cost (2) or less.
		//<b>招募</b>三个法力值消耗小于或等于（2）点的随从。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			string str = "我寻思出战斗号角应该能出: ";
			int cnt = 3;
			// 遍历卡组
			foreach(KeyValuePair<CardDB.cardIDEnum, int>kvp in p.prozis.turnDeck )
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				if( deckMinion.cost <= 2 ){
					int pos = p.ownMinions.Count ;
					p.callKid(deckMinion, pos, ownplay);
					str += deckMinion.nameCN + " ";
					cnt--;
					if(cnt <= 0)break;
				}
			}
			if (cnt == 0 && p.ownMinions.Count < 7) p.evaluatePenality -= 30;
			Helpfunctions.Instance.ErrorLog(str);
		}
	}
}
