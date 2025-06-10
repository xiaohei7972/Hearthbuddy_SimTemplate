using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_EX1_571 : SimTemplate //* 自然之力 Force of Nature
//Summon three 2/2 Treants with<b>Charge</b> that die at the end of the turn.
//召唤三个2/2并具有<b>冲锋</b>的树人，在回合结束时，消灭这些树人。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
