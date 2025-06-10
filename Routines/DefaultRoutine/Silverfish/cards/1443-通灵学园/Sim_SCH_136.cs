using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_136 : SimTemplate //* 真言术：宴 Power Word: Feast
	{
		//Give a minion +2/+2. Restore it to full Health at the end of this turn.
		//使一个随从获得+2/+2。在本回合结束时，使其恢复所有生命值。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
