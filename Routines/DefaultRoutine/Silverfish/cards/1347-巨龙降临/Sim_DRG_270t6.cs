using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_270t6 : SimTemplate //* 玛里苟斯的变形术 Malygos's Polymorph
	{
		//Transform a minioninto a 1/1 Sheep.
		//使一个随从变形成为1/1的绵羊。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
