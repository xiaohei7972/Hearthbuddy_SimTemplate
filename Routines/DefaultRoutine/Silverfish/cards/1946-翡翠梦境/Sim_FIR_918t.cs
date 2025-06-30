using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：3
	//Light of the Full Moon
	//满月辉光
	//Give a minion +3/+3. Add a Light of the New Moon to your hand.
	//使一个随从获得+3/+3。将一张新月辉光置入你的手牌。
	class Sim_FIR_918t : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 3, 3);
				p.drawACard(CardDB.cardIDEnum.FIR_918, ownplay, true);
			}

		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
			};
        }
		
	}
}
