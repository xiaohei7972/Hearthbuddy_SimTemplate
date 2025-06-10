using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOTA_BOSS_36p : SimTemplate //* 发芽的孢子 Sprouting Spore
	{
		//<b>Hero Power</b>Summon an <b><i>extremely</i></b>Deadly_Spore.
		//<b>英雄技能</b>召唤一个<b><i>极为</i></b>致命的孢子。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
