using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_EX1_308 : SimTemplate //* 灵魂之火 Soulfire
//[x]Deal $4 damage.Discard a random card.
//造成$4点伤害，随机弃一张牌。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
