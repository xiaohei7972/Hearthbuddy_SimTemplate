using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_BOSS_73px : SimTemplate //* 大地母亲之怒 Earthmother's Rage
	{
		//<b>Hero Power</b>Give a friendly minion <b>Mega-Windfury</b>.
		//<b>英雄技能</b>使一个友方随从获得<b>超级风怒</b>。
		
		

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
