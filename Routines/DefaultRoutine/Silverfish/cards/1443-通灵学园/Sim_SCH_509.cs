using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_509 : SimTemplate //* 冰冷智慧 Brain Freeze
	{
		//<b>Freeze</b> a minion. <b>Combo:</b> Also deal $3 damage to it.
		//<b>冻结</b>一个随从。<b>连击：</b>并对其造成$3点伤害。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
