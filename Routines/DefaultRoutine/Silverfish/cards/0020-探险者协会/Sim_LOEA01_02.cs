using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOEA01_02 : SimTemplate //* 太阳祝福 Blessings of the Sun
//<b>Passive Hero Power</b>Whoever controls the Rod of the Sun is <b>Immune.</b>
//<b>被动英雄技能</b>谁控制了炎日权杖，便获得<b>免疫</b>。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
