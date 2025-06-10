using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_252 : SimTemplate //* 复苏 Renew
	{
		//Restore #3 Health. <b>Discover</b> a spell.
		//恢复#3点生命值。<b>发现</b>一张法术牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
