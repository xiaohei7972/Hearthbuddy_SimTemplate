using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_HERO_04ebp : SimTemplate //* 援军 Reinforce
	{
		//<b>Hero Power</b>Summon a 1/1 Silver Hand Recruit.
		//<b>英雄技能</b>召唤一个1/1的白银之手新兵。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
