using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：3 生命值：2
	//Questing Assistant
	//任务助理
	//[x]<b>Battlecry:</b> If you playeda <b>Quest</b> this game,deal 2 damage.
	//<b>战吼：</b>如果你在本局对战中使用过<b>任务</b>牌，造成2点伤害。
	class Sim_TLC_987 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null && (CardDB.cardtype)target.handcard.card.type == CardDB.cardtype.MOB)
			{
				p.minionGetDamageOrHeal(target, 3);
			}
		}


		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_DRAG_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 没目标也能使用
			};
		}

	}
}
