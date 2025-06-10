using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GILA_600p : SimTemplate //* 开炮！ Fire!
	{
		//<b>Hero Power</b>Fire your Cannons!If they kill any minions, refresh this.
		//<b>英雄技能</b>开炮！如果消灭任意随从，则复原该技能。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_EXACT_COST),
            };
        }
	}
}
