using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Fertilize
	//施加肥料
	//Draw a minion.
	//抽一张随从牌。
	class Sim_EDR_843b : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			// 抽随从
			List<CardDB.cardIDEnum> mob = p.CheckTurnDeckForType(CardDB.cardtype.MOB, 1);
			CardDB.cardIDEnum mobcard = mob.Count == 1 ? mob[0] : CardDB.cardIDEnum.None;
			p.drawACard(mobcard, ownplay);

		}

	}
}
