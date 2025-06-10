using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_BOSS_64px : SimTemplate //* 投资 Invest!
	{
		//<b>Hero Power</b>Return a friendly minion to your hand, then give it +4/+4 and copy it.
		//<b>英雄技能</b>将一个友方随从移回你的手牌，使其获得+4/+4并复制该随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
