using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_CS2_073 : SimTemplate //* 冷血 Cold Blood
//Give a minion +2 Attack. <b>Combo:</b> +4 Attack instead.
//使一个随从获得+2攻击力；<b>连击：</b>改为获得+4攻击力。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
