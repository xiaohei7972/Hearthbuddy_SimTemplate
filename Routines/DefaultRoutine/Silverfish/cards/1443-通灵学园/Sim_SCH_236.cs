using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_236 : SimTemplate //* 笔记能手 Diligent Notetaker
	{
		//<b>Spellburst:</b> Return the spell to your hand.
		//<b>法术迸发：</b>将法术牌移回你的手牌。
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
		{
			if (m.own == ownplay && m.Spellburst && hc.card.type == CardDB.cardtype.SPELL)
			{
				m.Spellburst = false;
				p.drawACard(CardDB.cardIDEnum.None, m.own,true);
			}
		}
	}
}
