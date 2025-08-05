using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：3 攻击力：4 生命值：3
	//Playmaker
	//团伙核心
	//[x]After you play a <b>Rush</b>minion, summon a copy_with 1 Health remaining.
	//在你使用一张<b>突袭</b>随从牌后，召唤一个剩余生命值为1的复制。
	class Sim_SCH_317 : SimTemplate
	{
		public override void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (triggerEffectMinion.own == wasOwnCard)
			{
				if (triggerEffectMinion.own && playedMinion.handcard.card.Rush)
				{
					//callKid不反回召唤后的随从,不好改动召唤物的属性
					//以后改动callKid再写召唤一个剩余生命值为1的复制
					p.callKid(playedMinion.handcard.card, triggerEffectMinion.zonepos, triggerEffectMinion.own);
				}
			}
		}

	}
}
