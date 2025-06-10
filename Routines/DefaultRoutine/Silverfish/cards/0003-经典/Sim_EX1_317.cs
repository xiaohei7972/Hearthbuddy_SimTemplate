using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_317 : SimTemplate //* 感知恶魔 Sense Demons
	{
		//Draw 2 Demonsfrom your deck.
		//从你的牌库中抽两张恶魔牌。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}

	}
}