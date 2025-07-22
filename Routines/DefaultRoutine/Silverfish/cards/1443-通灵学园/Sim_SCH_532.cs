using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_532 : SimTemplate //* 双盾优等生 Goody Two-Shields
	{
		//<b>Divine Shield</b><b>Spellburst:</b> Gain <b>Divine Shield</b>.
		//<b>圣盾，法术迸发：</b>获得<b>圣盾</b>。
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
		{
			if (m.own == ownplay && m.Spellburst && hc.card.type == CardDB.cardtype.SPELL)
			{
				m.Spellburst = false;
				if (!m.divineshild) { m.divineshild = true;  p.evaluatePenality -= 10; }
				else p.evaluatePenality += 10;
			}
		}
	}
}
