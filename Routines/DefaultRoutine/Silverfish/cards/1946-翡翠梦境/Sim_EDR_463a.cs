using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：2
	//Constricting Thorns
	//操纵荆棘
	//Destroy a minion with3 or less Attack.
	//消灭一个攻击力小于或等于3的随从。
	class Sim_EDR_463a : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

			if (target != null)
			{
				p.minionGetDestroyed(target);
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_MAX_ATTACK, 3), // 目标攻击力小于3
				// new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 无目标时也可以使用
			};
		}

	}
}
