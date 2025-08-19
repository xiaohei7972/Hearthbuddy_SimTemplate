using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：4
	//Cultivate
	//悉心栽培
	//Draw a spell.
	//抽一张法术牌。
	class Sim_TOY_801a : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
		}

	}
}
