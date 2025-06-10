using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_202a : SimTemplate //* 亚煞极之力 Y'Shaarj's Strength
//Summon a 2/2 Slime.
//召唤一个2/2的泥浆怪。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
