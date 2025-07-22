using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_720 : SimTemplate //* 沼泽女王的召唤 Swampqueen's Call
	{
		//Transform your minions into random <b>Legendary</b> minions. Repeatable this turn.
		//随机将你的所有随从变形成为<b>传说</b>随从。在本回合可以重复使用。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
