using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：8
	//Hydration Station
	//补水区
	//Resurrect three of your different highest Cost <b>Taunt</b> minions.
	//复活你法力值消耗最高的三个不同的<b>嘲讽</b>随从。
	class Sim_VAC_948 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count; // 位置
			List<CardDB.Card> reborntankCard = new List<CardDB.Card>();

			foreach (KeyValuePair<CardDB.cardIDEnum, int> e in p.ownGraveyard)
			{
				// 获取已死亡的随从卡牌
				CardDB.Card card = CardDB.Instance.getCardDataFromID(e.Key);
				//如果不是随从或者随从没有嘲讽,则跳过这次循环
				if (card.type != CardDB.cardtype.MOB && !card.tank) continue;

				reborntankCard.Add(card);
			}

			reborntankCard.Sort((a, b) => b.cost - a.cost);
			
			for (int i = 0; i < 3; i++)
			{
				if (reborntankCard.Count > i)
					p.callKid(reborntankCard[i], pos, ownplay);
			}
		}

	}
}
