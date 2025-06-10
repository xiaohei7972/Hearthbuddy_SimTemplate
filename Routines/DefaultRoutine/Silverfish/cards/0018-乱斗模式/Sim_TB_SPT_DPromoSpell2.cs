using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_SPT_DPromoSpell2 : SimTemplate //* 召唤守卫 Summon Guardians
//Summon two 2/4 Guardians.
//召唤两个2/4的守卫。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
