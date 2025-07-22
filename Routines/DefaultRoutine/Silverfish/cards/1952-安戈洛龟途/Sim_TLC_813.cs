using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：1
	//Purifying Vines
	//纯净藤蔓
	//Choose a minion.If it's friendly, give it +2 Health. If it's an enemy, give it -2 Health.
	//选择一个随从。如果是友方随从，使其获得+2生命值；如果是敌方随从，使其获得-2生命值。
	class Sim_TLC_813 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (target != null)
			{
				if (target.own == ownplay)
				{
					p.minionGetBuffed(target, 0, 2);
				}
				else
				{
					p.minionGetBuffed(target, 0, -2);
				}
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
