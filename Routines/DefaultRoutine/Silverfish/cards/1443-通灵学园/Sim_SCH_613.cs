using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_613 : SimTemplate //* 园地管理员 Groundskeeper
	{
		//[x]<b>Taunt</b><b>Battlecry:</b> If you're holding aspell that costs (5) or more,restore 5 Health.
		//<b>嘲讽，战吼：</b>如果你的手牌中有法力值消耗大于或等于（5）点的法术牌，恢复5点生命值。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
