using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_132 : SimTemplate //* 铁木树皮 Ironbark
	{
		//Give a minion +1/+3 and <b>Taunt</b>.Costs (0) if you have at least 7 Mana Crystals.
		//使一个随从获得+1/+3和<b>嘲讽</b>。如果你拥有至少七个法力水晶，则法力值消耗为（0）点。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
