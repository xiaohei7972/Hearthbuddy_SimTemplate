using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_Shaman_HP1 : SimTemplate //* 异变 Evolution
	{
		//<b>Hero Power</b>Transform a friendly minion into one that costs (1) more.
		//<b>英雄技能</b>将一个友方随从变形成为一个法力值消耗增加（1）点的随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
