using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：1
	//Play Dead
	//装死
	//Trigger a friendly minion's <b>Deathrattle</b>.
	//触发一个友方随从的<b>亡语</b>。
	class Sim_ICC_052_Puzzle : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				target.handcard.card.sim_card.onDeathrattle(p, target);
			}
		}


		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_DRAG_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_DEATHRATTLE), // 只能是亡语随从
			};
		}

	}
}
