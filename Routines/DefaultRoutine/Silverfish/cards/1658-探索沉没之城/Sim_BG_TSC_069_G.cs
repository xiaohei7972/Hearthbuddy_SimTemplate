using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：4 生命值：6
	//Amalgam of the Deep
	//深海融合怪
	//[x]<b>Battlecry:</b> Choose a friendlyminion. <b>Discover</b> 2 minionsof the same minion type.
	//<b>战吼：</b>选择一个友方随从，<b>发现</b>2张相同类型的随从牌。
	class Sim_BG_TSC_069_G : SimTemplate
	{
        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 26), // 只能是有种族的目标
			};
        }
	}
}
