using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：2
	//Arson Accusation
	//纵火指控
	//Choose a minion. Destroy it after your hero takes damage.
	//选择一个随从，在你的英雄受到伤害后将其消灭。
	class Sim_MAW_001 : SimTemplate
	{
		
		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
			};

        }
	}
}
