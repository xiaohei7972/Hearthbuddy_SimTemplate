using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TU4c_006 : SimTemplate //* 香蕉 Bananas
	{
		//Give a friendly minion +1/+1. <i>(+1 Attack/+1 Health)</i>
		//使一个友方随从获得+1/+1。<i>（+1攻击力/+1生命值）</i>
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
