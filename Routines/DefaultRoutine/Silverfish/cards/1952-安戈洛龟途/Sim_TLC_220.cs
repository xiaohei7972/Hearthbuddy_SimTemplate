using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：4 攻击力：4 生命值：5
	//Windswept Pageturner
	//扫页疾风
	//[x]After you summon anElemental, deal 3 damageto a random enemy.
	//在你召唤一个元素后，随机对一个敌人造成3点伤害。
	class Sim_TLC_220 : SimTemplate
	{
		public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
		{
			if (triggerEffectMinion.own == summonedMinion.own && (CardDB.Race)summonedMinion.handcard.card.race == CardDB.Race.ELEMENTAL)
			{
				p.DealDamageToRandomCharacter(triggerEffectMinion.own, 3);
			}
		}

	}
}
