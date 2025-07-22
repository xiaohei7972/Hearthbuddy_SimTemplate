using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：3
	//Treachery
	//变节
	//Choose a friendly minion and give it to_your opponent.
	//选择一个友方随从，交给你的对手。
	class Sim_CORE_ICC_206 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetControlled(target, !ownplay, false, true);
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 只能是友方
			};
		}

	}
}
