using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ICCA05_002p : SimTemplate //* 吸血撕咬 Vampiric Bite
//<b>Hero Power</b>Give a non-Vampire +2/+2. You <i>must</i> use this.
//<b>英雄技能</b>使一个非吸血鬼获得+2/+2。你<b>必须</b>使用该英雄技能。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_NOT_VAMPIRE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
