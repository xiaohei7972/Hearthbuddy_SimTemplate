using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_HERO_04ebp2 : SimTemplate //* 白银之手 The Silver Hand
	{
		//<b>Hero Power</b>Summon two 1/1 Recruits.
		//<b>英雄技能</b>召唤两个1/1的白银之手新兵。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
