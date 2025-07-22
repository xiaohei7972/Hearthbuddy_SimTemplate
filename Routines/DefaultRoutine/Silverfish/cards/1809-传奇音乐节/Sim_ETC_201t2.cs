using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：1
	//Bunch of Bananas
	//一串香蕉
	//Give a minion +1/+1.<i>(Last Banana!)</i>
	//使一个随从获得+1/+1。<i>（最后一根香蕉！）</i>
	class Sim_ETC_201t2 : SimTemplate
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
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 只能是友方
			};
		}
		
	}
}
