using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_KaraPortal_002 : SimTemplate //* 星光璀璨 Call Mediva
//Summon a random Mediva
//随机召唤一个麦迪瓦乐队成员 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
