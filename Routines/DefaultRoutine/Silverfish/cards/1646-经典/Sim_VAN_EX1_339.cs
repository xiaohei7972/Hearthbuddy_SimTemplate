using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_339 : SimTemplate //* 思维窃取 Thoughtsteal
	{
		//Copy 2 cards in your opponent's deck and add them to your hand.
		//复制你对手的牌库中的两张牌，并将其置入你的手牌。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
		}

	}
}