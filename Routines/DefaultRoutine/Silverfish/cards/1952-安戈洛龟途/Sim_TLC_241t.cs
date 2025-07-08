using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：2
	//Call the Threshfleet!
	//呼叫蛇颈龙群
	//Give a minion +2/+2 and <b>Divine Shield</b>. <i>(This stays in your hand while Ido is alive!)</i>
	//使一个随从获得+2/+2和<b>圣盾</b>。<i>（当伊度存活时，本牌会保留在你手中！）</i>
	class Sim_TLC_241t : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 2, 2);
				if (!target.divineshild)
					target.divineshild = true;
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
