using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：2
	//Emerald Bounty
	//翡翠厚赠
	//Draw 2 cards.You can't play themfor 2 turns.
	//抽两张牌。你无法在2回合内使用这些牌。
	class Sim_EDR_234 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			// p.owncards[p.owncards.Count].enchs.Add(CardDB.cardIDEnum.EDR_234e2);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			// p.owncards[p.owncards.Count].enchs.Add(CardDB.cardIDEnum.EDR_234e2);
		}

	}
}
