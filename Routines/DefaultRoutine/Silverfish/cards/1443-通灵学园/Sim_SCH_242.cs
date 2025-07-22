using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_242 : SimTemplate //* 聒噪怪 Gibberling
	{
		//<b>Spellburst:</b> Summon a Gibberling.
		//<b>法术迸发：</b>召唤一个聒噪怪。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_242);
        public override void OnSpellburst(Playfield p, Minion m, Handmanager.Handcard hc)
		{
			if(p.ownMinions.Count < 7)
            {
				p.callKid(kid, p.ownMinions.Count, true);
				p.evaluatePenality -= 8;
			}else
            {
				p.evaluatePenality += 10;
			}
		}

	}
}
