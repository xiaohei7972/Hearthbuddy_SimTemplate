using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_141 : SimTemplate //* 高阶修士奥露拉 High Abbess Alura
	{
		//<b>Spellburst:</b> Cast a spell from your deck <i>(targets this if possible)</i>.
		//<b>法术迸发：</b>从你的牌库中施放一张法术牌<i>（尽可能以该随从为目标）</i>。
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
		{
			if (m.own == ownplay && m.Spellburst && hc.card.type == CardDB.cardtype.SPELL)
			{
				m.Spellburst = false;
				p.minionGetBuffed(m, 8, 8);
			}
		}

	}
}
