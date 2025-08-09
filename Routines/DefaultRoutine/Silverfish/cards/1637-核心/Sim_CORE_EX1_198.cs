using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 娜塔莉·塞林 Natalie Seline
	//<b>Battlecry:</b> Destroy a minion and gain its Health.
	//<b>战吼：</b>消灭一个随从并获得其生命值。
	class Sim_CORE_EX1_198 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetDestroyed(target);
				p.minionGetBuffed(own, 0, target.Hp);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),	// 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 没有目标时也能用
			};
		}
		
	}
}
