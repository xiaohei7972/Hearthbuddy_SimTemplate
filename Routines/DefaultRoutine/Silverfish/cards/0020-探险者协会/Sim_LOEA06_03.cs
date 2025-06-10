using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOEA06_03 : SimTemplate //* 活化岩土 Animate Earthen
//Give your minions +1/+1 and <b>Taunt</b>.
//使你的所有随从获得+1/+1和<b>嘲讽</b>。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 1),
            };
        }
	}
}
