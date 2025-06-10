using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_249 : SimTemplate //* 空翻杂技 Acrobatics
	{
		//Draw 2 cards. If you play both this turn, draw 2 more.
		//抽两张牌。在本回合中，如果你使用了这两张牌，再抽两张。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.SCH_713, ownplay);
			p.drawACard(CardDB.cardIDEnum.ULD_191, ownplay);
			var newHc = p.owncards[p.owncards.Count - 2];
		}
	}
}
