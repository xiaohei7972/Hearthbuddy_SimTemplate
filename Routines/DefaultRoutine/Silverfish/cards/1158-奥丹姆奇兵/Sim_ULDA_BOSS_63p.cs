using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_63p : SimTemplate //* 瘟疫使者 Plaguebringer
	{
		//[x]<b>Passive Hero Power</b>Your spells <b>Overload</b> (1)but cost (2) less.
		//<b>被动英雄技能</b>你的法术牌会<b>过载</b>（1）点，但法力值消耗减少（2）点。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
