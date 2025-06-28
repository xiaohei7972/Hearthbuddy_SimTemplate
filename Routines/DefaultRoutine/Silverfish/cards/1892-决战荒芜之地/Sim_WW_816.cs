using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：3
	//Take to the Skies
	//飞向天空
	//Draw two Dragons.Give them +1/+1.
	//抽两张龙牌，使其获得+1/+1。
	class Sim_WW_816 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			// p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			// p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			for (int i = 0; i < 2; i++)
			{
				foreach (CardDB.Card card in p.ownDeck)
				{
					if ((TAG_RACE)card.race == TAG_RACE.DRAGON)
					{
						p.drawACard(card.cardIDenum, ownplay);
						p.owncards[p.owncards.Count - 1].addattack++;
						p.owncards[p.owncards.Count - 1].addHp++;
						p.anzOwnExtraAngrHp += 2;
						continue;
					}
				}
			}

		}

	}
}
