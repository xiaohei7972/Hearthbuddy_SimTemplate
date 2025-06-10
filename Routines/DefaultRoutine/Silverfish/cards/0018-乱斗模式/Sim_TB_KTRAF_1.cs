using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_KTRAF_1 : SimTemplate //* 阿努布雷坎 Anub'Rekhan
//At the end of your turn, summon a 3/1 Nerubian.
//在你的回合结束时，召唤一个3/1的蛛魔。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
