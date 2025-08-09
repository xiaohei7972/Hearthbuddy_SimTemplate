using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：3
	//Overheat
	//过热
	//Give your minions +1/+1. Discard a random Nature spell to give them +1/+1 more.
	//使你的随从获得+1/+1。随机弃一张自然法术牌以使其再获得+1/+1。
	class Sim_FIR_906 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.allMinionOfASideGetBuffed(ownplay, 1, 1);
			if (ownplay)
			{
				foreach (Handmanager.Handcard hc in p.owncards.ToArray())
				{
					if (hc.card.type == CardDB.cardtype.SPELL && hc.card.SpellSchool == CardDB.SpellSchool.NATURE)
					{
						p.discardCards(1, ownplay);
						p.allMinionOfASideGetBuffed(ownplay, 1, 1);
						break;
					}

				}

			}
		}

	}
}
