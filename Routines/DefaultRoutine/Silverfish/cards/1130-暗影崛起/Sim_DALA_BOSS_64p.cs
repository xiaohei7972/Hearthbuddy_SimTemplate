using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_BOSS_64p : SimTemplate //* 投资 Invest!
	{
		//<b>Hero Power</b>Return a friendly minion to your hand. Give it +4/+4.
		//<b>英雄技能</b>将一个友方随从移回你的手牌，使其获得+4/+4。
		
		

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
