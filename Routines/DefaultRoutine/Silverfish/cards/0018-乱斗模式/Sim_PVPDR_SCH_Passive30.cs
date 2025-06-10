using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Passive30 : SimTemplate //* 瘟疫使者 Plaguebringer
	{
		//<b>Passive</b>Your spells Overload (1) and cost (2) less, but not less than (1).
		//<b>被动</b>你的法术牌会过载（1）点，法力值消耗减少（2）点，但不能少于（1）点。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
