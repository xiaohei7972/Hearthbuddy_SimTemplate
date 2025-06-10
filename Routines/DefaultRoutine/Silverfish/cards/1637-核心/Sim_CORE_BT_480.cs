using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_BT_480 : SimTemplate //* 火色魔印奔行者 Crimson Sigil Runner
	{
		//<b>Outcast:</b> Draw a card.
		//<b>流放：</b>抽一张牌。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
		{
			if (outcast)
			{
				p.drawACard(CardDB.cardNameEN.unknown, ownplay);
				p.evaluatePenality -= 50;
			}
			else p.evaluatePenality += 10;
		}
	}
}
