using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Prologue_MoongladePortal : SimTemplate //* 月光林地传送门 Moonglade Portal
	{
		//Restore #6 Health. Summon a random6-Cost minion.
		//恢复#6点生命值。随机召唤一个法力值消耗为（6）的随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
