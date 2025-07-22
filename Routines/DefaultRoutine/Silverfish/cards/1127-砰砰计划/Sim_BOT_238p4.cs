using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_238p4 : SimTemplate //* 无人运输机 Delivery Drone
	{
		//<b>Hero Power</b><b>Discover</b> a Mech.Swaps_each_turn.
		//<b>英雄技能</b><b>发现</b>一张机械牌。每回合切换。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_HAND_NOT_FULL),
            };
        }
	}
}
