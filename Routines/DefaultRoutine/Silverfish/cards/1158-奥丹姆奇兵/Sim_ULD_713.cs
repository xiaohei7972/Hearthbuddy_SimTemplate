using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_713 : SimTemplate //* 飞蝗虫群 Swarm of Locusts
	{
		//Summon seven 1/1 Locusts with <b>Rush</b>.
		//召唤七只1/1并具有<b>突袭</b>的蝗虫。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
