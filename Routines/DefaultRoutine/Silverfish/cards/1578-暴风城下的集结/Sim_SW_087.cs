using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：3
	//Dreaded Mount
	//恐惧坐骑
	//[x]Give a minion +1/+1.When it dies, summonan endless Dreadsteed.
	//使一个随从获得+1/+1。当该随从死亡时，召唤一匹无尽的恐惧战马。
	class Sim_SW_087 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 1, 1);
			}

		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从

			};

		}
		
	}
}
