using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Scripting.Utils;

namespace HREngine.Bots
{
	//地标 萨满祭司 费用：5
	//The Galaxy's Lens
	//星系投影
	//<b><b>Spellburst</b>:</b> Absorb the spell's power!@Cast {0}.
	//<b><b>法术迸发</b>：</b>吸收法术的能量！@施放{0}。
	class Sim_GDB_136t : SimTemplate
	{
		CardDB.Card card = null;
		PlayReq[] playReqs = new PlayReq[]{ };
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (p.mana < p.ownMaxMana)
				p.evaluatePenality -= 30;
			if (triggerMinion.handcard.card.CooldownTurn == 0)
			{
				if (triggerMinion.handcard.enchs.Count > 0)
				{
					CardDB.Card card = CardDB.Instance.getCardDataFromID(triggerMinion.handcard.enchs[0]);
					playReqs = card.sim_card.GetPlayReqs();
					card.sim_card.onCardPlay(p, triggerMinion.own, target, 1);

				}
			}
		}

		public override void OnSpellburst(Playfield p, Minion m, Handmanager.Handcard hc)
		{
			m.handcard.enchs.Add(hc.card.cardIDenum);
		}

		public override PlayReq[] GetUseAbilityReqs()
		{
			playReqs.AddRange(card.sim_card.GetPlayReqs());
			return playReqs;
		}

	}
}
