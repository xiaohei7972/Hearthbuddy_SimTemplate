using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRGA_BOSS_04t : SimTemplate //* 巨龙吐息 Dragonbreath
	{
		//Deal $4 damage to a minion. If you're holding a Dragon, return this to your hand.
		//对一个随从造成$4点伤害。如果你的手牌中有龙牌，则将此法术牌移回你的手牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
