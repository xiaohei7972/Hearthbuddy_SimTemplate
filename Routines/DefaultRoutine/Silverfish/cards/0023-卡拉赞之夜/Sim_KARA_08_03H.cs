using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KARA_08_03H : SimTemplate //* 虚空吐息 Nether Breath
//[x]Change the Health ofall enemy minions to 1.
//将所有敌方随从的生命值变为1。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
