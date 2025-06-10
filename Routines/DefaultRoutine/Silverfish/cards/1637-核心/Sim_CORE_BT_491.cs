using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_BT_491 : SimTemplate //* 幽灵视觉 Spectral Sight
	{
		//[x]Draw a card.<b>Outcast:</b> Draw another.
		//抽一张牌。<b>流放：</b>再抽一张。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
		{
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			if (outcast) p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			else p.evaluatePenality += 3;
		}
	}
}
