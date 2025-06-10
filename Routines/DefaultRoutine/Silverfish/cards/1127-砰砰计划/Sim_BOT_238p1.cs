using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_238p1 : SimTemplate //* 电磁炮 Zap Cannon
	{
		//<b>Hero Power</b>Deal $3 damage.Swaps each turn.
		//<b>英雄技能</b>造成$3点伤害。每回合切换。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
