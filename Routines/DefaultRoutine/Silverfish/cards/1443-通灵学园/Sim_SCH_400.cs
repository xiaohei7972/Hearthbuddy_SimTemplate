using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：5 攻击力：3 生命值：8
	//Mozaki, Master Duelist
	//决斗大师莫扎奇
	//After you cast a spell, gain <b>Spell Damage +1</b>.
	//在你施放一个法术后，获得<b>法术伤害+1</b>。
	class Sim_SCH_400 : SimTemplate
	{
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (triggerEffectMinion.own == wasOwnCard)
			{
				if (hc.card.type == CardDB.cardtype.SPELL)
				{
					triggerEffectMinion.spellpower++;
				}
			}
		}
		public override void onAuraStarts(Playfield p, Minion m)
		{
			if (m.own) p.spellpower += m.spellpower;
			else p.enemyspellpower += m.spellpower;
		}
		
		public override void onAuraEnds(Playfield p, Minion m)
		{
			if (m.own) p.spellpower -= m.spellpower;
			else p.enemyspellpower -= m.spellpower;
		}

	}
}
