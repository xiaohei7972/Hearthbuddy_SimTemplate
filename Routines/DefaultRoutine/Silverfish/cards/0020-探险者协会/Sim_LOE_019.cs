using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_019 : SimTemplate //* 石化迅猛龙 Unearthed Raptor
//<b>Battlecry:</b> Choose a friendly minion. Gain a copy of its_<b>Deathrattle</b>.
//<b>战吼：</b>选择一个友方随从，获得其<b>亡语</b>的复制。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_DEATHRATTLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
