using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 中立 费用：1
	//Un'Goro Jungle
	//安戈洛丛林
	//{0} {1}
	//{0}{1}
	class Sim_TLC_100t1 : SimTemplate
	{
		public override PlayReq[] GetUseAbilityReqs()
		{
			return new PlayReq[]
			{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标必须是友方随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标必须是友方随从
				// new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 没目标时也能用
			};
		}

	}
}
