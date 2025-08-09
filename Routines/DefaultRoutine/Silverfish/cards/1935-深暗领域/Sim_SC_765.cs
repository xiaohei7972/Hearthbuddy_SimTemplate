using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：6 攻击力：3 生命值：5
	//High Templar
	//高阶圣堂武士
	//[x]<b>Battlecry:</b> Deal 2 damageto all enemies.<i>Play another Templar tomerge into an Archon!</i>
	//<b>战吼：</b>对所有敌人造成2点伤害。<i>再使用一张圣堂武士即可融合为执政官！</i>
	class Sim_SC_765 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_756t);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.allCharsOfASideGetDamage(!own.own, 2);
		}
		//需要改进下onCardIsGoingToBePlayed方法,不然不好对打出的卡牌继续处理
		// public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
		// {
		// 	if (triggerEffectMinion.own == wasOwnCard && (hc.card.cardIDenum == CardDB.cardIDEnum.SC_752 || hc.card.cardIDenum == CardDB.cardIDEnum.SC_765))
		// 	{
		// 		p.minionGetDestroyed(triggerEffectMinion);
		// 		p.callKid(kid, triggerEffectMinion.zonepos - 1, triggerEffectMinion.own);
		// 	}
		// }
		public override void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (triggerEffectMinion.own == wasOwnCard && (playedMinion.handcard.card.cardIDenum == CardDB.cardIDEnum.SC_752 || playedMinion.handcard.card.cardIDenum == CardDB.cardIDEnum.SC_765))
			{
				p.minionGetDestroyed(playedMinion);
				p.minionGetDestroyed(triggerEffectMinion);
				p.callKid(kid, triggerEffectMinion.zonepos - 1, triggerEffectMinion.own);
			}
		}

	}
}
