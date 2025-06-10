using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_113 : SimTemplate //* 图腾映像 Totemic Reflection
	{
		//Give a minion +2/+2.If it's a Totem, summon a copy of it.
		//使一个随从获得+2/+2。如果该随从是图腾，召唤一个它的复制。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
