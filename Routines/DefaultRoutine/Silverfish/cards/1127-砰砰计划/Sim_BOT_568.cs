using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_568 : SimTemplate //* 莫瑞甘的灵界 The Soularium
	{
		//Draw 3 cards.At the end of your turn, discard them.
		//抽三张牌。在你的回合结束时，弃掉它们。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, true);
			p.drawACard(CardDB.cardIDEnum.None, true);
			p.drawACard(CardDB.cardIDEnum.None, true);
		}

	}
}
