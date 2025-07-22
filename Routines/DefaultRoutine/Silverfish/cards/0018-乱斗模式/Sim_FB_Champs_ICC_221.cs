using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_ICC_221 : SimTemplate //* 吸血药膏 Leeching Poison
//Give your weapon <b>Lifesteal</b>.
//使你的武器获得<b>吸血</b>。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_WEAPON_EQUIPPED),
            };
        }
	}
}
