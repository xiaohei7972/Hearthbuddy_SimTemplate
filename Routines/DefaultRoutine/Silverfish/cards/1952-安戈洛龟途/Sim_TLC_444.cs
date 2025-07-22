using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：2
	//Story of Galvadon
	//嘉沃顿的故事
	//Give a minion three random <b>Bonus Effects</b>.
	//使一个随从获得三项随机<b>额外效果</b>。
	class Sim_TLC_444 : SimTemplate
	{
		
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
