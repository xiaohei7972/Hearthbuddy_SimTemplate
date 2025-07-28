using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 圣骑士 费用：3
	//Ruins of Korune
	//寇茹废墟
	//Draw 2 cards.Swap their Costs.
	//抽两张牌，交换其法力值消耗。
	class Sim_WON_053t6 : SimTemplate
	{
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (triggerMinion.handcard.card.CooldownTurn == 0)
			{
				p.drawACard(CardDB.cardIDEnum.None, triggerMinion.own);
				p.drawACard(CardDB.cardIDEnum.None, triggerMinion.own);
			}

		}
		
	}
}
