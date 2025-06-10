using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_319 : SimTemplate //* 农夫 Peasant
	{
		//At the start of your turn, draw a card.
		//在你的回合开始时，抽一张牌。
		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
		{
			if (triggerEffectMinion.own == turnStartOfOwner)
			{
				p.drawACard(CardDB.cardIDEnum.None, turnStartOfOwner);
			}
		}
	}
}
