using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：3
	//Libram of Clarity
	//明澈圣契
	//Draw 2 minions.If this costs (0), give them +2/+1.
	//抽两张随从牌。如果本牌的法力值消耗为（0）点，使抽到的随从牌获得+2/+1。
	class Sim_GDB_137 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			int count = 2;
			foreach (var item in p.prozis.turnDeck)
			{
				CardDB.Card card = CardDB.Instance.getCardDataFromID(item.Key);
				if (card.type == CardDB.cardtype.MOB)
				{
					p.drawACard(item.Key, ownplay);
					if (hc.card.cost == 0)
					{
						p.owncards[p.owncards.Count].addattack += 2;
						p.owncards[p.owncards.Count].addHp += 1;
					}
					count--;
				}
				if (count == 0) return;
			}
		}

	}
}
