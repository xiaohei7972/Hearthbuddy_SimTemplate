using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：1
	//Azsharan Gardens
	//艾萨拉的花园
	//Give all minions in your hand +1/+1. Put a 'Sunken Gardens' on the bottom of your deck.
	//使你手牌中的所有随从牌获得+1/+1。将一张沉没的花园置于你的牌库底。
	class Sim_TSC_927 : SimTemplate
	{
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_927t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB)
					{
						hc.addattack++;
						hc.addHp++;
						p.anzOwnExtraAngrHp += 2;
					}
				}

				p.AddToDeck(card);

			}

		}

	}
}
