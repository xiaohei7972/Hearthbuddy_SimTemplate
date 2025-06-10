using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_Noblegarden_003t6 : SimTemplate //* 粉色幻彩染料 Pink Shifting Dye
//Dye an Egg. When it hatches, it grants <b>Taunt</b>.
//为一枚彩蛋上色。当其孵化时，获得<b>嘲讽</b>。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 38),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
