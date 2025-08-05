using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：3 攻击力：1 生命值：3
	//Blindeye Sharpshooter
	//盲眼神射手
	//[x]After you play a Naga,deal 2 damage to a randomenemy and draw a spell.<i>(Then switch!)</i>@[x]After you cast a spell,deal 2 damage to a randomenemy and draw a Naga.<i>(Then switch!)</i>
	//在你使用一张纳迦牌后，随机对一个敌人造成2点伤害，抽一张法术牌。<i>（然后切换！）</i>@在你施放一个法术后，随机对一个敌人造成2点伤害，抽一张纳迦牌。<i>（然后切换！）</i>
	class Sim_WW_402 : SimTemplate
	{
		//用数字代表状态
		int status = 0;

		public override void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (triggerEffectMinion.own == wasOwnCard)
			{
				//判断打出的随从是否为娜迦或全部，并且判断状态是0
				if (RaceUtils.IsRaceOrAll(playedMinion.handcard.card.race, CardDB.Race.NAGA) && status == 0)
				{
					//随机对一个目标造成2点伤害
					p.DealDamageToRandomCharacter(triggerEffectMinion.own, 2);
					// 遍历我方牌库
					foreach (var item in p.prozis.turnDeck)
					{
						CardDB.Card card = CardDB.Instance.getCardDataFromID(item.Key);
						//判断牌库里的卡是否为娜迦
						if (RaceUtils.IsRaceOrAll(card.race, CardDB.Race.NAGA))
						{
							p.drawACard(item.Key, triggerEffectMinion.own);
							break;
						}
						//切换状态
						status = 1;
					}
				}
			}
		}

		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (triggerEffectMinion.own == wasOwnCard)
			{
				//判断打出的卡是否为法术，并且判断状态是1
				if (hc.card.type == CardDB.cardtype.SPELL && status == 1)
				{
					//随机对一个目标造成2点伤害
					p.DealDamageToRandomCharacter(triggerEffectMinion.own, 2);
					// 遍历我方牌库
					foreach (var item in p.prozis.turnDeck)
					{
						CardDB.Card card = CardDB.Instance.getCardDataFromID(item.Key);
						//判断牌库里的卡是否为法术
						if (card.type == CardDB.cardtype.SPELL)
						{
							p.drawACard(item.Key, triggerEffectMinion.own);
							break;
						}
					}
					//切换状态
					status = 0;
				}

			}
		}



	}
}
