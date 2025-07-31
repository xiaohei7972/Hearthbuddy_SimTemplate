using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//Find a Triple
	//寻找三连
	//Draw a minion.Get 2 copies of it.
	//抽一张随从牌。获取2张它的复制。
	class Sim_BG31_BOBt4 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				foreach (var item in p.prozis.turnDeck)
				{
					CardDB.Card card = CardDB.Instance.getCardDataFromID(item.Key);
					if (card.type == CardDB.cardtype.MOB)
					{
						p.drawACard(item.Key, ownplay);
						p.drawACard(item.Key, ownplay, true);
						p.drawACard(item.Key, ownplay, true);

					}
				}
			}
			
		}

	}
}
