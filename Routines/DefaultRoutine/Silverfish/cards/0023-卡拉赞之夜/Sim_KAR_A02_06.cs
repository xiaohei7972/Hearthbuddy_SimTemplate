using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_A02_06 : SimTemplate //* 餐壶 Pitcher
//<b>Battlecry:</b> Give a minion +2/+2.
//<b>战吼：</b>使一个随从获得+2/+2。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
