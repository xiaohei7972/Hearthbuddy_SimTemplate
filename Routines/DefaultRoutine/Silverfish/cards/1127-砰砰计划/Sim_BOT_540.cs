using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_540 : SimTemplate //* 电磁脉冲特工 E.M.P. Operative
	{
		//<b>Battlecry:</b> Destroy a Mech.
		//<b>战吼：</b>消灭一个机械。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 17),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
