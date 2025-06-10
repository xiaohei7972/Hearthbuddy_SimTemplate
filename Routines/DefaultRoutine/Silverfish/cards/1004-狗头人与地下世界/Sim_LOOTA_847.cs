using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOTA_847 : SimTemplate //* 拟态面具 Mask of Mimicry
	{
		//Choose a minion.Minions in your hand become copies of it.
		//选择一个随从。你手牌中的所有随从牌都变成它的复制。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
