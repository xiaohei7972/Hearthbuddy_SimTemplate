using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_Noblegarden_003t4 : SimTemplate //* 银色幻彩染料 Silver Shifting Dye
//Dye an Egg. When it hatches, it grants <b>Stealth</b>.
//为一枚彩蛋上色。当其孵化时，获得<b>潜行</b>。 
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
