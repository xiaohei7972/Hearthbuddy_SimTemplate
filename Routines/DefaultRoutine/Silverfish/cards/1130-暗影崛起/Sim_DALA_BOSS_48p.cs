using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_BOSS_48p : SimTemplate //* 逐入虚空 To The Void
	{
		//<b>Hero Power</b>Banish a minion to the Void.
		//<b>英雄技能</b>将一个随从逐入虚空。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
