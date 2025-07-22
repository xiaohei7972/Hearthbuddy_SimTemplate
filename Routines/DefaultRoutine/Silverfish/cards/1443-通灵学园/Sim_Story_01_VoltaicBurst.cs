using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_01_VoltaicBurst : SimTemplate //* 流电爆裂 Voltaic Burst
	{
		//Summon two 1/1 Sparks with <b>Rush</b>.
		//召唤两个1/1并具有<b>突袭</b>的“火花”。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
