using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_717 : SimTemplate //* 潜地蝎 Burrowing Scorpid
	{
		//[x]<b>Battlecry:</b> Deal 2 damage.If that kills the target,gain <b>Stealth</b>.
		//<b>战吼：</b>造成2点伤害。如果消灭了目标，则获得<b>潜行</b>。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
