using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_199t14 : SimTemplate //* 转校生 Transfer Student
	{
		//[x]<b>Deathrattle:</b> Add a random<b>Death Knight</b> card toyour hand.
		//<b>亡语：</b>随机将一张<b>死亡骑士</b>牌置入你的手牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
