using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：6 攻击力：5 生命值：3
	//Dark Templar
	//黑暗圣堂武士
	//[x]<b>Stealth</b>. <b>Battlecry:</b> Destroyan enemy minion.<i>Play another Templar tomerge into an Archon!</i>
	//<b>潜行</b>。<b>战吼：</b>消灭一个敌方随从。<i>再使用一张圣堂武士即可融合为执政官！</i>
	class Sim_SC_752 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_756t);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetDestroyed(target);
			}
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

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_DRAG_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 目标只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 物目标时也能使用
			};
		}
	}
}
