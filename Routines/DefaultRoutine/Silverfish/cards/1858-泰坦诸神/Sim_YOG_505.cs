using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Bestial Madness
	//兽性癫狂
	//[x]Give +1 Attack to allminions in your hand,deck, and battlefield.
	//使你手牌，牌库和战场上的所有随从获得+1攻击力。
	class Sim_YOG_505 : SimTemplate
	{

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			List<Minion> Minions = ownplay ? p.ownMinions : p.enemyMinions;
			if (Minions.Count > 0)
			{
				foreach (Minion minion in Minions)
				{
					p.minionGetBuffed(minion, 1, 0);
				}
			}

			if (ownplay)
			{
				// 增强手牌中的所有随从
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB)
					{
						hc.addattack += 1;
					}
				}

				// 增强牌库中的所有随从
				foreach (CardDB.Card card in p.ownDeck)
				{
					if (card.type == CardDB.cardtype.MOB)
					{
						card.Attack += 1; // 增加攻击力
					}
				}
			}

		}
	}
}
