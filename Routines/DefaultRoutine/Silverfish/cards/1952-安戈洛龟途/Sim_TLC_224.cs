using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：4 攻击力：2 生命值：5
	//Mechanized Magma
	//机械熔火
	//Whenever you play aFire spell, gain statsequal to its Cost.
	//每当你使用一张火焰法术牌时，获得等同于其法力值消耗的属性值。
	class Sim_TLC_224 : SimTemplate
	{
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL && hc.card.SpellSchool == CardDB.SpellSchool.FIRE)
			{
				int buff = hc.getManaCost(p);
				p.minionGetBuffed(triggerEffectMinion, buff, buff);
			}
		}

	}
}
