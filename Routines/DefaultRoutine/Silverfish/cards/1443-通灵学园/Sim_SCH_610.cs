using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_610 : SimTemplate //* 动物保镖 Guardian Animals
	{
		//Summon two Beasts that cost (5) or less from your deck. Give_them <b>Rush</b>.
		//从你的牌库中召唤两只法力值消耗小于或等于（5）点的野兽，并使其获得<b>突袭</b>。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int cnt = 2;
			// 遍历卡组
			foreach(KeyValuePair<CardDB.cardIDEnum, int>kvp in p.prozis.turnDeck )
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				// 5费以下野兽
				if(deckMinion.race == CardDB.Race.BEAST && deckMinion.cost <= 5){
					int pos = p.ownMinions.Count ;
					p.callKid(deckMinion, pos, ownplay);
					p.minionGetBuffed(p.ownMinions[pos], p.deckAngrBuff, p.deckHpBuff);
					// 并使其获得突袭 FIXME 有报错
					// if (p.ownMinions.Count >= 1)
					// {
					// 	Minion summonedMinion = p.ownMinions[pos];
					// 	// Helpfunctions.Instance.ErrorLog("召唤了"+summonedMinion.handcard.card.chnName+",对应"+deckMinion.chnName);
					// 	if (summonedMinion.handcard.card.cardIDenum == deckMinion.cardIDenum)
					// 	{
					// 		p.minionGetRush(summonedMinion);
					// 	}
					// }
					// Helpfunctions.Instance.ErrorLog("我寻思出动物保镖应该能出"+deckMinion.chnName+"吧？");
					cnt--;
					if(cnt <= 0)break;
				}
			}
			foreach (Minion m in p.ownMinions)
			{
				if(!m.cantAttack){
					p.minionGetRush(m);
				}				
			}
		}
		
	}
}
