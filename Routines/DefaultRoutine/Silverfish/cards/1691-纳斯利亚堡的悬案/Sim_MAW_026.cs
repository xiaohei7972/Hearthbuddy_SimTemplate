using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：3
	//Incarceration
	//监禁
	//[x]Choose a minion.It goes <b>Dormant</b>for 3 turns.
	//选择一个随从。使其<b>休眠</b>3回合。
	class Sim_MAW_026 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				target.dormant = 3;
				target.updateReadyness();
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
			};

		}
		
	}
}
