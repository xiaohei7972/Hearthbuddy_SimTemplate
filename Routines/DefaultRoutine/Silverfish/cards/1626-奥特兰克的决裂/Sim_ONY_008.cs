using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Furious Howl
	//狂怒之嚎
	//Draw a card.Repeat until you have at least 3 cards.
	//抽一张牌。重复，直到你拥有至少三张牌。
	class Sim_ONY_008 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			while (p.owncards.Count < 3)
			{
				p.drawACard(CardDB.cardIDEnum.None, ownplay);
			}

		}

	}
}
