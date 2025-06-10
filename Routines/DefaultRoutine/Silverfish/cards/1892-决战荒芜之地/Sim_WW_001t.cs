using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Rock
	//石头
	//Deal $3 damage.
	//造成$3点伤害。
	class Sim_WW_001t : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			// 对目标造成3点伤害
			p.minionGetDamageOrHeal(target, 3);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2. REQ_TARGET_TO_PLAY),
			};
		}
	}
}