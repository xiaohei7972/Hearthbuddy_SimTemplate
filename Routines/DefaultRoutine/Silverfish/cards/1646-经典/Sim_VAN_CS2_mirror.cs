using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_mirror : SimTemplate //* 镜像 Mirror Image
	{
		//<b>Taunt</b>
		//<b>嘲讽</b>
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
