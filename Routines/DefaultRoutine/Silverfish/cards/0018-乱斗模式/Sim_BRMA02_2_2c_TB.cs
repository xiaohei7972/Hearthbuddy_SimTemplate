using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA02_2_2c_TB : SimTemplate //* 强势围观 Jeering Crowd
//Summon a 1/1 Spectator with <b>Taunt</b>.
//召唤一个1/1并具有<b>嘲讽</b>的观众。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
