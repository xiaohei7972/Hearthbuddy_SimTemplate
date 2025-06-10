using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 猎人 费用：2
	//Castle Kennels
	//城堡狗舍
	//[x]{0}{1}
	//{0}{1}
	class Sim_REV_790 : SimTemplate
	{
		
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			// 检查目标是否为有效随从
			if (target != null)
			{
				// 给目标随从增加 +2 攻击力
				p.minionGetBuffed(target, 2, 0);

				// 如果目标是野兽，则赋予其突袭
				if (target.handcard.card.race == CardDB.Race.BEAST)
				{
					target.rush = 1;
				}
			}
		}

		public override PlayReq[] GetUseAbilityReqs()
		{
			return new PlayReq[]
			{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标必须是友方随从
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是一个随从
			};
		}
	}
}
