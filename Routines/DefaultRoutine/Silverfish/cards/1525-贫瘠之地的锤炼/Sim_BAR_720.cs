using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：3 攻击力：2 生命值：4
	//Guff Runetotem
	//古夫·符文图腾
	//After you cast a Nature spell, give another friendly minion +2/+2.
	//在你施放一个自然法术后，使另一个友方随从获得+2/+2。
	class Sim_BAR_720 : SimTemplate
	{
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL && hc.card.SpellSchool == CardDB.SpellSchool.NATURE)
			{
				List<Minion> tmp = triggerEffectMinion.own ? p.ownMinions : p.enemyMinions;
				foreach (Minion m in tmp)
				{
					if (triggerEffectMinion.entitiyID == m.entitiyID) continue;
					p.minionGetBuffed(m, 2, 2);
					break;
				}
			}
		}

	}
}
