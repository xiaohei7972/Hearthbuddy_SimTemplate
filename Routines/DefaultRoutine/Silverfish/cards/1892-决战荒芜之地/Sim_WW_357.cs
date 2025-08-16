using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：4 攻击力：2 生命值：8
	//Maw and Paw
	//老腐和老墓
	//[x]At the end of your turn, gain5 <b>Corpses</b>. At the start of yourturn, spend 5 <b>Corpses</b> to giveyour hero +5 Health.
	//在你的回合结束时，获得5份<b>残骸</b>。在你的回合开始时，消耗5份<b>残骸</b>，使你的英雄获得+5生命值。
	class Sim_WW_357 : SimTemplate
	{
		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
		{
			if (triggerEffectMinion.own == turnStartOfOwner)
			{
				if (triggerEffectMinion.own)
					p.addCorpses(5);
			}
		}
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			if (triggerEffectMinion.own == turnEndOfOwner)
			{
				if (triggerEffectMinion.own)
				{
					p.corpseConsumption(5);
					p.minionGetBuffed(p.ownHero, 0, 5);
				}
			}
		}

	}
}
