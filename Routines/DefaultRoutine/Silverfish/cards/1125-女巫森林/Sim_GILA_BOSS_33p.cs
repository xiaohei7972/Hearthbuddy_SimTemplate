using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GILA_BOSS_33p : SimTemplate //* 收割 Harvest
	{
		//<b>Hero Power</b>Destroy a friendly minion. Restore #8_Health to your hero.
		//<b>英雄技能</b>消灭一个友方随从。为你的英雄恢复#8点生命值。
		
		

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
