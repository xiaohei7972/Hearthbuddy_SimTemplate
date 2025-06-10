using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_Chupacabran_HP : SimTemplate //* 嗜血渴望 Bloodthirst
//<b>Hero Power</b>Give a friendly minion +1/+1 and <b>Lifesteal</b>.
//<b>英雄技能</b>使一个友方随从获得+1/+1和<b>吸血</b>。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
