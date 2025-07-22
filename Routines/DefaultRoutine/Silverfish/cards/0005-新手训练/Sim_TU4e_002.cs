using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TU4e_002 : SimTemplate //* 埃辛诺斯之焰 Flames of Azzinoth
	{
		//<b>Hero Power</b>Summon two 2/1 minions.
		//<b>英雄技能</b>召唤两个2/1的随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
