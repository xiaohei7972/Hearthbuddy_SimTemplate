using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOTA_BOSS_29p : SimTemplate //* 强力异变 Greater Evolution
	{
		//<b>Hero Power</b>Transform a minion into a random one that costs (3) more.
		//<b>英雄技能</b>将一个随从随机变形成为法力值消耗增加（3）点的随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
