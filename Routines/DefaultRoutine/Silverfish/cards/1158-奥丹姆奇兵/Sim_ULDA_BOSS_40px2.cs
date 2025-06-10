using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_40px2 : SimTemplate //* 愤怒碾压 Wrath Smash
	{
		//[x]<b>Hero Power</b>Destroy a damaged minion.Costs (1) more for eachdamaged minion.
		//<b>英雄技能</b>消灭一个受伤的随从。每有一个受伤的随从，该技能的法力值消耗增加（1）点。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET),
            };
        }
	}
}
