using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：5 攻击力：5 生命值：5
	//Shoplifter Goldbeard
	//大盗金胡子
	//[x]After you summon aPirate, summon a copy ofit that attacks a randomenemy, then dies.
	//在你召唤一个海盗后，召唤一个它的复制并使其攻击随机敌人然后死亡。
	class Sim_TOY_511 : SimTemplate
	{
		// 可能无限回调,就先注释掉了
		// public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
		// {
		// 	if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own && RaceUtils.IsRaceOrAll(summonedMinion.handcard.card.race, CardDB.Race.PIRATE))
		// 	{
				// 想办法获取召唤后的随从的复制的实体id,然后和原随从实体id做对比
		// 		if (summonedMinion.entitiyID != summonedMinion.entitiyID)
		// 			p.callKid(summonedMinion.handcard.card, triggerEffectMinion.zonepos, triggerEffectMinion.own);

		// 	}
		// }

	}
}
