using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_196 : SimTemplate //* 击碎者克里丹 Keli'dan the Breaker
	{
		//[x]<b>Battlecry:</b> Destroy a minion.If drawn this turn, insteaddestroy all minionsexcept this one.
		//<b>战吼：</b>消灭一个随从。如果该牌在本回合被抽到，则改为消灭除此随从外的所有随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
