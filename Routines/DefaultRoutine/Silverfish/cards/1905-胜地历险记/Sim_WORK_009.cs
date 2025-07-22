using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：2 攻击力：3 生命值：2
	//Imployee of the Month
	//月度魔范员工
	//<b>Battlecry:</b> Give a friendly minion <b>Lifesteal</b>.
	//<b>战吼：</b>使一个友方随从获得<b>吸血</b>。
	class Sim_WORK_009 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			// 判断目标是否为友方随从
			if (target != null && target.own)
			{
				target.lifesteal = true;
			}

		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 无目标时也可以使用
            };
		}
	}
}
