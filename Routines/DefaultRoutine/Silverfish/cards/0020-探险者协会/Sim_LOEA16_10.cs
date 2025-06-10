using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOEA16_10 : SimTemplate //* 哈卡莱血祭杯 Hakkari Blood Goblet
//Transform a minion into a 2/1 Pit Snake.
//使一个随从变形成为2/1的深渊巨蟒。 
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
