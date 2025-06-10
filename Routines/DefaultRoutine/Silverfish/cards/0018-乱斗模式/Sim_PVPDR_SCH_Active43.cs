using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active43 : SimTemplate //* 神圣典籍 Holy Book
	{
		//<b>Silence</b> and destroy a minion. Summon a 10/10 copy of it.
		//<b>沉默</b>并消灭一个随从。召唤一个它的10/10复制。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
