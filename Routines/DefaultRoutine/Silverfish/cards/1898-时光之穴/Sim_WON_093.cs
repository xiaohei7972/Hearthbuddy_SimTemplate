using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：2
	//Demonfuse
	//恶魔融合
	//Give a Demon +3/+3.
	//使一个恶魔获得+3/+3。
	class Sim_WON_093 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 3, 3);
			}

		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				// new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE,15), // 目标只能是恶魔

			};

		}
		
	}
}
