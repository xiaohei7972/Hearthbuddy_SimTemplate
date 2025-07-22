using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BTA_BOSS_22p : SimTemplate //* 死亡之影 Shadow of Death
	{
		//<b>Hero Power</b>Summon a 4/4 Shadowy Construct.
		//<b>英雄技能</b>召唤一个4/4的阴暗构造体。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
