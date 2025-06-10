using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_199t2 : SimTemplate //* 转校生 Transfer Student
	{
		//<b>Battlecry:</b> Deal 2 damage.
		//<b>战吼：</b>造成2点伤害。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
