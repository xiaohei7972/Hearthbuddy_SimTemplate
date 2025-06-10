using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_KT_AnubarakHP : SimTemplate //* 飞掠召唤 Skitter
//<b>Hero Power</b>Summon a 4/4 Nerubian.
//<b>英雄技能</b>召唤一个4/4的蛛魔。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
