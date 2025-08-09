using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：2
	//Smoldering Grove
	//焚火林地
	//Draw {0} |4(card, cards).<i>(Upgrades each turn,but discards after {1}!)</i>@Draw {0} cards.<i>(Discards this turn!)</i>
	//抽{0}张牌。<i>（每回合都会升级，但本牌会在{1}回合后弃掉！）</i>@抽{0}张牌。<i>（本牌会在本回合弃掉！）</i>
	class Sim_FIR_911 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			for (int i = 0; i < hc.card.TAG_SCRIPT_DATA_NUM_1; i++)
			{
				p.drawACard(CardDB.cardIDEnum.None, ownplay);
			}
		}

		public override void onTurnEndsTrigger(Playfield p, Handmanager.Handcard hc, bool turnEndOfOwner)
		{
			if (turnEndOfOwner)
			{
				hc.card.TAG_SCRIPT_DATA_NUM_1++;
				if (hc.card.TAG_SCRIPT_DATA_NUM_1 > 2)
				{
					hc.temporary = true;
				}
			}
		}

	}
}
