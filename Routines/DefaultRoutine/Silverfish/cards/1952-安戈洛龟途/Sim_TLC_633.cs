using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：4 攻击力：5 生命值：3
	//Bugsquasher
	//害虫克星
	//<b>Battlecry:</b> Deal 6 damage to an enemy minion with a minion type.
	//<b>战吼：</b>对一个具有随从类型的敌方随从造成6点伤害。
	class Sim_TLC_633 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null && !target.own && target.handcard.card.race != CardDB.Race.BLANK)
			{
				p.minionGetDamageOrHeal(target, 6);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_MUST_HAVE_TAG), // 只能是具有随从类型的目标 好像写了也没用
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 无目标时也能用
			};
		}

	}
}
