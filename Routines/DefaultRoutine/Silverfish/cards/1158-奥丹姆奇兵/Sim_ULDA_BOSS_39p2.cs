using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_39p2 : SimTemplate //* 死灰复燃 Ashes Anew
	{
		//[x]<b>Hero Power</b>Destroy a friendly Murlocto summon a Scaly Golem.
		//<b>英雄技能</b>消灭一个友方鱼人，召唤一个石鳞魔像。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 14),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
