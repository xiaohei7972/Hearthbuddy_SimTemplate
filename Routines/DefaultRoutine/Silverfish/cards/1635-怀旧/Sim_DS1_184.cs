using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DS1_184 : SimTemplate //* 追踪术 Tracking
	{
		//<b>Discover</b> a card from your deck.
		//从你的牌库中<b>发现</b>一张牌。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}

	}
}