using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOTA_231 : SimTemplate //* 孵化器 Incubator
	{
		//<b>Battlecry:</b> Choose a minion.<b>Deathrattle:</b> Summon a copy of it.
		//<b>战吼：</b>选择一个随从。<b>亡语：</b>召唤一个所选随从的复制。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
