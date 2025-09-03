using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：5 攻击力：2 生命值：2
	//Possessed Lackey
	//着魔男仆
	//<b>Deathrattle:</b> <b>Recruit</b> a_Demon.
	//<b>亡语：</b><b>招募</b>一个恶魔。
	class Sim_FB_Champs_LOOT_306 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				// 招募恶魔
				if (deckMinion.type == CardDB.cardtype.MOB && deckMinion.race == CardDB.Race.DEMON)
				{
					int pos = m.own ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(deckMinion, pos, m.own);
					break;
				}
			}
		}
		
	}
}
