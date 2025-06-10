using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_023 : SimTemplate //* 奥术智慧 Arcane Intellect
	{
		//Draw 2 cards.
		//抽两张牌。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}

	}
}