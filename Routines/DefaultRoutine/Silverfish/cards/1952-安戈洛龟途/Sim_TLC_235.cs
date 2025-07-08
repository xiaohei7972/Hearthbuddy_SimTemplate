using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：1
	//Life Cycle
	//生命循环
	//Destroy a minion. Summon a random minion of the sameCost to replace it.
	//消灭一个随从，随机召唤一个法力值消耗相同的随从来替换它。
	class Sim_TLC_235 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int cost = target.handcard.card.cost;
				p.minionGetDestroyed(target);
				p.callKid(p.getRandomCardForManaMinion(cost), target.zonepos - 1, ownplay);
			}
		}


		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从

			};
		}
	}
}
