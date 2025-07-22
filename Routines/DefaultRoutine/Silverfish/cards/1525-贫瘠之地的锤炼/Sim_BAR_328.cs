using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_328 : SimTemplate //* 复仇之魂 Vengeful Spirit
	{
		//<b>Outcast:</b> Draw 2 <b>Deathrattle</b> minions.
		//<b>流放：</b>抽两张<b>亡语</b>随从牌。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
		{
			if (outcast)
			{
				p.drawACard(CardDB.cardNameEN.unknown, ownplay);
				p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			}
			else p.evaluatePenality += 10;
		}
	}
}
