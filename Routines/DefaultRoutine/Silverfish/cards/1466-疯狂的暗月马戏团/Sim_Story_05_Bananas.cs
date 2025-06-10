using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_05_Bananas : SimTemplate //* 香蕉 Bananas
	{
		//<i>You can now fight the Monkey King!</i>Give a minion +1/+1.
		//<i>现在你可以挑战美猴王了！</i>使一个随从获得+1/+1。
		
		

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
