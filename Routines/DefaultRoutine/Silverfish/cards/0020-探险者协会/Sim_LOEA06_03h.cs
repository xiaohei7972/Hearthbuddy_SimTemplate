using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOEA06_03h : SimTemplate //* 活化岩土 Animate Earthen
//Give your minions +3/+3 and <b>Taunt</b>.
//使你的所有随从获得+3/+3和<b>嘲讽</b>。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 1),
            };
        }
	}
}
