using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_Priest_HP1 : SimTemplate //* 扭曲 Distort
	{
		//<b>Hero Power</b>Swap a minion's Attack and Health.
		//<b>英雄技能</b>使一个随从的攻击力和生命值互换。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
