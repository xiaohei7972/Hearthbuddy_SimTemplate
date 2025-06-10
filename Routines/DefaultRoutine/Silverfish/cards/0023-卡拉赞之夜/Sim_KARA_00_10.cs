using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KARA_00_10 : SimTemplate //* 神秘符文 Mysterious Rune
//Put 5 random Mage <b>Secrets</b> into the battlefield.
//随机将5个法师<b>奥秘</b>置入战场。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_SECRET_ZONE_CAP_FOR_NON_SECRET),
            };
        }
	}
}
